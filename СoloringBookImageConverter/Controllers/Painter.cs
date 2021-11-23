
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Painter
    {
        //PaintDotNet p = new PaintDotNet
        private byte[,] palette; //палитра
        private int paletteSize;
        private byte[,,] qByteIMG;
        private int minimalRegionSize;
        private int minimalFontSize;
        private ImageQuantizer imageQuantizer;
        private BitmapConverter bitmapConverter;
        private Bitmap bitmapEdges;
        private int[,] regionsArray;
        private List<List<Point>> fontsRegions;

        public Painter(int minimalRegionSize, int minimalFontSize, int paletteSize)
        {
            bitmapConverter = new BitmapConverter();
            this.paletteSize = paletteSize;
            this.minimalRegionSize = minimalRegionSize;
            this.minimalFontSize = minimalFontSize;
        }

        public Painter(int minimalRegionSize, int minimalFontSize, byte[,] palette)
        {
            bitmapConverter = new BitmapConverter();
            this.palette = palette;
            this.minimalRegionSize = minimalRegionSize;
            this.minimalFontSize = minimalFontSize;
        }

        public void makeEdgesImage(Bitmap bitmap, int blurIndex)
        {
           // List<Region> regions = new List<Region>();
            imageQuantizer = new ImageQuantizer();
            //загрузил квантизированный массив пикселей
            if (palette == null)
            {
                qByteIMG = imageQuantizer.getQuantizedByteArray(bitmap, paletteSize);
                palette = imageQuantizer.GetPalette();
            }
            else qByteIMG = imageQuantizer.getQuantizedByteArray(bitmap, palette);
            int height = qByteIMG.GetLength(1), width = qByteIMG.GetLength(2);
            regionsArray = new int[height, width];  //хранит номер региона для каждого пикселя
            int currentRegionIndex = 1;  //номер последнего региона
            fontsRegions = new List<List<Point>>();
            for (int h = 0; h < height; h++) //высота картинки
            {
                int w = 0;
                while (w < width) //ширина картинки
                {
                    if (regionsArray[h, w] == 0) 
                    {
                        fontsRegions.Add(new List<Point>());
                        if (searchRegion(h, w, height, width, currentRegionIndex))  //если возвращает тру, значит регион не был присоединен к существующему
                        {
                            currentRegionIndex++; //это говно точно не должно выхождить пока не заполнит область квадратиком
                        }
                    }
                    w++;
                }
               // if (i % 10 == 0) form.setText(i.ToString() + "/" + regionsArray.GetLength(0).ToString());
            }
            byte[,,] edgesimage = getEdges(height, width);
            bitmapEdges = bitmapConverter.rgbToBitmapQ(edgesimage);
            Graphics g = Graphics.FromImage(bitmapEdges);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            //расставляю номера
            
            for (int i = 0; i < fontsRegions.Count; i++) //кол-во регионов
            {
                for (int j = 0; j < palette.GetLength(1); j++)
                {
                    if (qByteIMG[0,fontsRegions[i][0].X, fontsRegions[i][0].Y] == palette[0,j] 
                        && qByteIMG[1, fontsRegions[i][0].X, fontsRegions[i][0].Y] == palette[1, j]
                        && qByteIMG[2, fontsRegions[i][0].X, fontsRegions[i][0].Y] == palette[2, j])
                    {
                        int average = (fontsRegions[i].Count) / 2;
                        g.DrawRectangle(new Pen(new SolidBrush(Color.Red)), fontsRegions[i][average].Y, fontsRegions[i][average].X, 15, 15 / 2);
                        g.DrawString((j+1).ToString(), new Font("Arial", 8), new SolidBrush(Color.Black),
                        new Point(fontsRegions[i][average].Y, fontsRegions[i][average].X));
                        break;
                    }
                }
            }
            makePaletteFile();
        }
        
        //OK ищу регион и удаляю маленький пока не подберу нужный размер
        private bool searchRegion(int h, int w, int height, int width, int regionIndex)
        {
            int i = h, j = w, countOfPix;
            List<Point> edgesPoints;
            Stack<Point> stack;
            Point point = new Point();
            while (true)
            {
                h = i; w = j;
                edgesPoints = new List<Point>();
                stack = new Stack<Point>();
                countOfPix = 1;
                while (true)
                {
                    regionsArray[h, w] = regionIndex; //ставлю в найденную клетку номер региона
                    //на 12 часов свободная клетка того же цвета
                    if (h - 1 >= 0 && regionsArray[h - 1, w] == 0 && qByteIMG[0, h, w] == qByteIMG[0, h - 1, w]
                        && qByteIMG[1, h, w] == qByteIMG[1, h - 1, w] && qByteIMG[2, h, w] == qByteIMG[2, h - 1, w])
                    {
                        stack.Push(new Point(h, w)); //добавил в стек текущие координаты
                        countOfPix++;  //добавляю количесвто найденных клеток
                        h--;
                    }
                    //на 3 часа свободная клетка того же цвета
                    else if (w + 1 < width && regionsArray[h, w + 1] == 0 && qByteIMG[0, h, w] == qByteIMG[0, h, w + 1]
                        && qByteIMG[1, h, w] == qByteIMG[1, h, w + 1] && qByteIMG[2, h, w] == qByteIMG[2, h, w + 1])
                    {
                        stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                        countOfPix++;  //добавляю количесвто найденных клеток
                        w++;
                    }
                    //на 6 часов свободная клетка того же цвета
                    else if (h + 1 < height && regionsArray[h + 1, w] == 0 && qByteIMG[0, h, w] == qByteIMG[0, h + 1, w]
                        && qByteIMG[1, h, w] == qByteIMG[1, h + 1, w] && qByteIMG[2, h, w] == qByteIMG[2, h + 1, w])
                    {
                        stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                        countOfPix++;  //добавляю количесвто найденных клеток
                        h++;
                    }
                    //на 9 часов свободная клетка того же цвета
                    else if (w - 1 >= 0 && regionsArray[h, w - 1] == 0 && qByteIMG[0, h, w] == qByteIMG[0, h, w - 1]
                        && qByteIMG[1, h, w] == qByteIMG[1, h, w - 1] && qByteIMG[2, h, w] == qByteIMG[2, h, w - 1])
                    {
                        stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                        countOfPix++;  //добавляю количесвто найденных клеток
                        w--;

                    }
                    else
                    {

                        FontFits(h, w, regionIndex, false);
                        if (h - 1 >= 0 && regionsArray[h - 1, w] != regionIndex //сверху другой области
                        || w + 1 < width && regionsArray[h, w + 1] != regionIndex //справа другой области
                        || h + 1 < height && regionsArray[h + 1, w] != regionIndex //снизу другой области
                        || w - 1 >= 0 && regionsArray[h, w - 1] != regionIndex) //слева другой области
                        {
                            edgesPoints.Add(new Point(h, w));
                        }
                        if (stack.Count < 1 ) break;
                        point = stack.Pop();
                        h = point.X;
                        w = point.Y;
                    }
                }
               // ShowRegions();
                if (countOfPix < minimalRegionSize || fontsRegions[regionIndex - 1].Count == 0)
                {
                    Pixel maxAroundColor = getMaxAroundColor(regionIndex, edgesPoints);
                    connectRegionToMaxRegion(regionIndex, i, j, height, width, maxAroundColor);
                    //если заполнил не пустым регионом то брейк и искать только квадраты
                    if (maxAroundColor.Region != 0)
                    {
                        fontsRegions.RemoveAt(regionIndex - 1);
                        return false;
                    }
                    //ShowRegions();
                }
                else if (regionsArray[i, j] != 0) return true;
            }
        }
        //заливаю маленький регион цветом большего ближайшего региона
        private void connectRegionToMaxRegion(int oldRegionIndex, int h, int w, int height, int width, Pixel maxAroundColor)
        {
            Point point = new Point();
            Stack<Point> stack = new Stack<Point>();
            byte R = maxAroundColor.R, G = maxAroundColor.G, B = maxAroundColor.B;
            int newRegionIndex = maxAroundColor.Region;
            //stack.Push(new Point(h, w));
            while (true)
            {
                //на 12 часов клетка того же цвета
                if (h - 1 >= 0 && regionsArray[h - 1, w] == oldRegionIndex
                    && qByteIMG[0, h, w] == qByteIMG[0, h - 1, w] 
                    && qByteIMG[1, h, w] == qByteIMG[1, h - 1, w] 
                    && qByteIMG[2, h, w] == qByteIMG[2, h - 1, w])
                {
                    regionsArray[h, w] = -1;
                    stack.Push(new Point(h, w)); //добавил в стек текущие координаты
                    h--;
                }
                //на 3 часа клетка того же цвета
                else if (w + 1 < width && regionsArray[h, w + 1] == oldRegionIndex
                    && qByteIMG[0, h, w] == qByteIMG[0, h, w + 1]
                    && qByteIMG[1, h, w] == qByteIMG[1, h, w + 1]
                    && qByteIMG[2, h, w] == qByteIMG[2, h, w + 1])
                {
                    regionsArray[h, w] = -1;
                    stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                    w++;
                }
                //на 6 часов клетка того же цвета
                else if (h + 1 < height && regionsArray[h + 1, w] == oldRegionIndex
                    && qByteIMG[0, h, w] == qByteIMG[0, h + 1, w]
                    && qByteIMG[1, h, w] == qByteIMG[1, h + 1, w]
                    && qByteIMG[2, h, w] == qByteIMG[2, h + 1, w])
                {
                    regionsArray[h, w] = -1;
                    stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                    h++;
                }
                //на 9 часов клетка того же цвета
                else if (w - 1 >= 0 && regionsArray[h, w - 1] == oldRegionIndex
                    && qByteIMG[0, h, w] == qByteIMG[0, h, w - 1]
                    && qByteIMG[1, h, w] == qByteIMG[1, h, w - 1]
                    && qByteIMG[2, h, w] == qByteIMG[2, h, w - 1])
                {
                    regionsArray[h, w] = -1;
                    stack.Push(new Point(h, w)); //добавил в стек предыдущие координаты
                    w--;
                }
                else
                {
                    qByteIMG[0, h, w] = R;
                    qByteIMG[1, h, w] = G;
                    qByteIMG[2, h, w] = B;
                    regionsArray[h, w] = newRegionIndex;
                    if (stack.Count < 1) break;
                    point = stack.Pop();
                    h = point.X;
                    w = point.Y;
                }
            }
        }
        //ищет часто встречающийся цвет вокруг удоляемого региона
        private Pixel getMaxAroundColor(int regionIndex, List<Point> edgesPoints)
        {
            List<Pixel> colorsList = new List<Pixel>(); //массив всех возможных цветов вокруг области
            int a, b;
            for (int z = 0; z < edgesPoints.Count; z++)
            {
                a = edgesPoints[z].X;
                b = edgesPoints[z].Y;
                //если на 12 часов клетка с другим цветом
                if (a - 1 >= 0 && regionsArray[a - 1, b] != regionIndex) a--;
                //если на 3 часа клетка с другим цветом
                else if (b + 1 < regionsArray.GetLength(1) && regionsArray[a, b + 1] != regionIndex) b++;
                //если на 6 часов клетка с другим цветом
                else if (a + 1 < regionsArray.GetLength(0) && regionsArray[a + 1, b] != regionIndex) a++;
                //если на 9 часов клетка с другим цветом
                else if (b - 1 >= 0 && regionsArray[a, b - 1] != regionIndex) b--;
                if (a != edgesPoints[z].X | b != edgesPoints[z].Y)
                {
                    int index = colorsList.IndexOf(new Pixel(qByteIMG[0, a, b], qByteIMG[1, a, b], qByteIMG[2, a, b]));
                    if (index < 0) colorsList.Add(new Pixel(qByteIMG[0, a, b], qByteIMG[1, a, b], qByteIMG[2, a, b], regionsArray[a, b]));
                    else colorsList[index].Size++;
                }
            }
            //запилить округление к меньшей или большей области
           /* int maxColor = 2000000000, k = 0;
            for (int z = 0; z < colorsList.Count; z++)
            {
                if (colorsList[z] == null) break;
                if (colorsList[z].Size < maxColor)
                {
                    maxColor = colorsList[z].Size;
                    k = z;
                }
            }*/
            int maxColor = 0, k = 0;
            for (int z = 0; z < colorsList.Count; z++)
            {
                if (colorsList[z] == null) break;
                if (colorsList[z].Size > maxColor)
                {
                    maxColor = colorsList[z].Size;
                    k = z;
                }
            }
            return colorsList[k];
        }
        //СТАБИЛЕН!!!   ищет переход между цветами и отмечает как границу
        public byte[,,] getEdges(int height, int width)
        {
            byte[,,] newArray = new byte[3, height, width];
            for (int i = 1; i < height; i++)  //h
            {
                for (int j = 0; j < width - 1; j++)//w
                {
                    if ((qByteIMG[0, i, j] != qByteIMG[0, i, j + 1] // текущий цвет не равне следующему
                        & qByteIMG[1, i, j] != qByteIMG[1, i, j + 1]
                        & qByteIMG[2, i, j] != qByteIMG[2, i, j + 1])
                        || (i > 0 &&
                                   (qByteIMG[0, i, j] != qByteIMG[0, i - 1, j]
                                  & qByteIMG[1, i, j] != qByteIMG[1, i - 1, j]
                                  & qByteIMG[2, i, j] != qByteIMG[2, i - 1, j]))
                        || (i < qByteIMG.GetLength(1) - 1 &&
                                   (qByteIMG[0, i, j] != qByteIMG[0, i + 1, j]
                                  & qByteIMG[1, i, j] != qByteIMG[1, i + 1, j]
                                  & qByteIMG[2, i, j] != qByteIMG[2, i + 1, j]))
                        || i == 0 | i == qByteIMG.GetLength(1) - 1
                        || j == 0 | j == qByteIMG.GetLength(2) - 1)
                    {
                        newArray[0, i, j] = newArray[1, i, j] = newArray[2, i, j]
                          = newArray[0, i, j + 1] = newArray[1, i, j + 1] = newArray[2, i, j + 1] = 0;
                    }
                    else newArray[0, i, j] = newArray[1, i, j] = newArray[2, i, j] = 255;
                }
            }
            return newArray;
        }

        private bool FontFits(int h, int w, int regionIndex, bool prewSquareIsFull)
        {
            if (h + minimalFontSize/2 >= regionsArray.GetLength(0) || w + minimalFontSize >= regionsArray.GetLength(1)
             || regionsArray[h + minimalFontSize/2, w] != regionIndex || regionsArray[h, w + minimalFontSize] != regionIndex
             || regionsArray[h + minimalFontSize/2, w + minimalFontSize] != regionIndex) return false;
            else
            {
                bool isFit = true; //допустим, что квадрат вписывается
                if (prewSquareIsFull) //если предыдущий квадрат был полон, то есть смысл изучить только последний столбец
                {
                    int b = w + minimalFontSize; //отмечаем последний столбец
                    for (int a = h; a <= h + minimalFontSize/2; a++) //цикл по высоте квадрата
                    {
                        if (qByteIMG[0, h, w] != qByteIMG[0, a, b]
                         || qByteIMG[1, h, w] != qByteIMG[1, a, b]
                         || qByteIMG[2, h, w] != qByteIMG[2, a, b])
                        {
                            isFit = false; //если цвет другой - значит квадтат не вписывается
                            goto End;
                        }
                    }
                }
                else
                {
                    for (int a = h; a <= h + minimalFontSize/2; a++) //высота квадрата
                    {
                        for (int b = w; b <= w + minimalFontSize; b++) //ширина квадрата
                        {
                            if (qByteIMG[0, h, w] != qByteIMG[0, a, b]
                             || qByteIMG[1, h, w] != qByteIMG[1, a, b]
                             || qByteIMG[2, h, w] != qByteIMG[2, a, b])
                            {
                                isFit = false;
                                goto End;
                            }
                        }
                    }
                }
                End:;
                //если квадрат вписывается - добавляем его левую-верхнюю координату к массиву координат для этого региона
                if (isFit)
                {
                    fontsRegions[regionIndex - 1].Add(new Point(h, w));
                    return true;
                }
                else return false;
            }
        }

        private void ShowRegions()
        {
            StreamWriter writeSiteInfo = new StreamWriter("out.txt");
            
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        writeSiteInfo.Write(regionsArray[i, j] + "\t");
                    }
                writeSiteInfo.WriteLine();
                }
                writeSiteInfo.Close();
        }

        public void changeMinRegionOrFontSize()
        {

        }
        public Bitmap getQuantizeBitmap()
        {
            return bitmapConverter.rgbToBitmapQ(qByteIMG);
        }
        public Bitmap getEdgesBitmap()
        {
            return bitmapEdges;
        }
        public void SetPaletteSize(int size)
        {
            paletteSize = size;
        }

        public void makePaletteFile()
        {
            int h = paletteSize * 50;
            Bitmap bmp = new Bitmap(h, 600);
            int numH = 10, numW = 10, colorH = 10, colorW = 60, colorH2 = 40, colorW2 = 200, hexH = 10, hexW = 230;
            Graphics g = Graphics.FromImage(bmp);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            for (int i = 0; i< paletteSize; i++)
            {
                g.DrawString((i+1).ToString(), new Font("Arial", 20), new SolidBrush(Color.Black), numW, numH);
                g.FillRectangle(new SolidBrush(Color.FromArgb(palette[0,i], palette[1, i], palette[2, i])), colorW, colorH, colorW2, colorH2);
                g.DrawString((Color.FromArgb(palette[0, i], palette[1, i], palette[2, i]).ToArgb() & 0x00FFFFFF).ToString("X6"), 
                    new Font("Arial", 20), new SolidBrush(Color.Black), hexW, hexH);
                numH += 50;
                colorH += 50;
                colorH2 += 50;
                hexH += 50;
            }
            bmp.Save("palette.png");

        }

        public Bitmap GetMedianImage(int radius)
        {
            return imageQuantizer.GetMedian(radius);
        }
    }
}
