using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using СoloringBookImageConverter.Models;

namespace СoloringBookImageConverter.Controllers
{
    class ImageQuantizer
    {
        private byte PBCr = 30, PBCg = 59, PBCb = 11;
        private byte[,,] qByteIMG;
        private byte[,] palette;
        private BitmapConverter bitmapConverter;

        public ImageQuantizer()
        {
            bitmapConverter = new BitmapConverter();
        }
        public byte[,,] getQuantizedByteArray(Bitmap image, int paletteSize)
        {
            byte[,,] arrayOfBytesIMG = bitmapConverter.bitmapToByteRgbQ(image); //получил из картинки массив пикселей (оптимизировано)
            Pixel[] pixels = convertArrayToPix(arrayOfBytesIMG, image.Width, image.Height); //получил обьекты-пиксели
            palette = getPaletteFromPix(pixels, paletteSize);  //получил палитру
            qByteIMG = setNewPaletteToImage(arrayOfBytesIMG); //квантизация
            return qByteIMG;
        }
        public byte[,,] getQuantizedByteArray(Bitmap image, byte[,] palette)
        {
            byte[,,] arrayOfBytesIMG = bitmapConverter.bitmapToByteRgbQ(image); //получил из картинки массив пикселей (оптимизировано)
            this.palette = palette;
            qByteIMG = setNewPaletteToImage(arrayOfBytesIMG); //квантизация
            return qByteIMG;
            //form.setText("1/6 получаю из картинки массив пикселей");
            //form.setText("2/6 получаю обьекты-пиксели");
            //form.setText("3/6 получаю палитру");             
            //form.setText("4/6 квантизирую");
            //form.setText("5/6 собираю изображение");
            //form.setOutpuImage(bitmapConverter.rgbToBitmapQ(qByteIMG)); //собираю изображение
            //form.setText("6/6 Собрано!");
        }
        public void setPBCRatio(byte PBCr, byte PBCg, byte PBCb)
        {
            this.PBCr = PBCr;
            this.PBCg = PBCg;
            this.PBCb = PBCb;
        }

        //конвертация массива байт в массив обьектов-пикселей
        private Pixel[] convertArrayToPix(byte[,,] res, int width, int helight)
        {
            Pixel[] output = new Pixel[width * helight];
            int k = 0;
            for (int i = 0; i < helight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    output[k] = new Pixel(res[0, i, j], res[1, i, j], res[2, i, j]);
                    k++;
                }
            }
            return output;
        }
        private Pixel[,] convertArrayToPix(byte[,,] res)
        {
            Pixel[,] output = new Pixel[res.GetLength(1), res.GetLength(2)];
            for (int i = 0; i < res.GetLength(1); i++)
            {
                for (int j = 0; j < res.GetLength(2); j++)
                {
                    output[i,j] = new Pixel(res[0, i, j], res[1, i, j], res[2, i, j]);
                }
            }
            return output;
        }
        //палитра не может быть больше чем количество пикселей
        private byte[,] getPaletteFromPix(Pixel[] pixels, int paletteSize)
        {
            List<Pixel[]> paletteFAT = new List<Pixel[]>();
            paletteFAT.Add(pixels);
            Pixel[] buf, buf2;
            int k = 0, indexOfColor;
            while (paletteFAT.Count - k < paletteSize)   //хуета
            {
                if (paletteFAT[k].Length > 1)
                {
                    pixels = paletteFAT[k];
                    indexOfColor = getColorIndexWithMaxDelta(pixels); //находим цвет с максимальным диапазоном
                    if (indexOfColor == 0) Array.Sort(pixels, new RComparer());
                    if (indexOfColor == 1) Array.Sort(pixels, new GComparer());
                    if (indexOfColor == 2) Array.Sort(pixels, new BComparer());

                    buf = new Pixel[pixels.Length / 2];
                    buf2 = new Pixel[(int)Math.Ceiling(pixels.Length / 2.0)];
                    for (int j = 0; j < buf2.Length; j++)
                    {
                        if (j < buf.Length)
                        {
                            buf[j] = pixels[j];
                        }
                        buf2[j] = pixels[j + buf.Length];
                    }
                    paletteFAT.Add(buf);
                    paletteFAT.Add(buf2);
                    paletteFAT.RemoveAt(k);
                    //если набрано нужное количество палитры
                    //если палитра разбилась до максимально возможной
                    k = 0;
                }
                else k++;
            }
            byte[,] palette = new byte[3, paletteSize];
            long sumR = 0, sumG = 0, sumB = 0;
            for (int i = 0; i < paletteFAT.Count; i++)
            {
                if (paletteFAT[i].Length > 1)
                {
                    sumR = 0; sumG = 0; sumB = 0;
                    for (int j = 0; j < paletteFAT[i].Length; j++)
                    {
                        sumR += paletteFAT[i][j].R;
                        sumG += paletteFAT[i][j].G;
                        sumB += paletteFAT[i][j].B;
                    }
                    palette[0, i] = (byte)(sumR / paletteFAT[i].Length);
                    palette[1, i] = (byte)(sumG / paletteFAT[i].Length);
                    palette[2, i] = (byte)(sumB / paletteFAT[i].Length);
                }
                else
                {
                    palette[0, i] = paletteFAT[i][0].R;
                    palette[1, i] = paletteFAT[i][0].G;
                    palette[2, i] = paletteFAT[i][0].B;
                }
            }
            return palette;
        }
        //получаем самый длинный цвет для сечения
        private int getColorIndexWithMaxDelta(Pixel[] pixels)
        {
            int maxR, minR, maxG, minG, maxB, minB;
            maxB = maxG = maxR = 0;
            minB = minG = minR = 255;
            //найдём диапазоны цветов
            for (int i = 0; i < pixels.Length; i++)
            {
                if (pixels[i].R > maxR) maxR = pixels[i].R;
                if (pixels[i].R < minR) minR = pixels[i].R;
                if (pixels[i].G > maxG) maxG = pixels[i].G;
                if (pixels[i].G < minG) minG = pixels[i].G;
                if (pixels[i].B > maxB) maxB = pixels[i].B;
                if (pixels[i].B < minB) minB = pixels[i].B;
            }
            int dR = maxR - minR; //диапазон красного
            int dG = maxG - minG; //диапазон зеленого
            int dB = maxB - minB; //диапазон синего
                                  //наёдем цвет с максимальным диапазоном
            int maxColor = 1; //индекс цвета с макс.диапазоном - дефолтный - зеленый
            if (dR > dB & dR > dG) maxColor = 0; //макс. красный
            else if (dB > dR & dB > dG) maxColor = 2; //макс.синий
            return maxColor;
        }
        //создание квантизированного массива
        private byte[,,] setNewPaletteToImage(byte[,,] array3D)
        {
            byte[,,] newArray = new byte[3, array3D.GetLength(1), array3D.GetLength(2)];
            double fi, fmin;
            fmin = 60000000;
            int indexMatchColor = 0;
            for (int i = 0; i < array3D.GetLength(1); i++)  //h
            {
                for (int j = 0; j < array3D.GetLength(2); j++)//w
                {
                    indexMatchColor = 0;
                    fmin = 60000000;
                    for (int z = 0; z < palette.GetLength(1); z++)
                    {
                        fi = PBCr * (array3D[0, i, j] - palette[0, z]) * (array3D[0, i, j] - palette[0, z])
                           + PBCg * (array3D[1, i, j] - palette[1, z]) * (array3D[1, i, j] - palette[1, z])
                           + PBCb * (array3D[2, i, j] - palette[2, z]) * (array3D[2, i, j] - palette[2, z]);
                        if (fi < fmin)
                        {
                            fmin = fi;
                            indexMatchColor = z;
                        }
                    }
                    newArray[0, i, j] = palette[0, indexMatchColor];
                    newArray[1, i, j] = palette[1, indexMatchColor];
                    newArray[2, i, j] = palette[2, indexMatchColor];
                }
            }
            return newArray;
        }

        public byte[,] GetPalette()
        {
            return palette;
        }

        
        public Bitmap GetMedian(int radius)
        {
            Pixel[,] pixels = convertArrayToPix(qByteIMG);
            List<Pixel> medianArea;

            for (int h = radius; h < qByteIMG.GetLength(1) - radius; h++)
            {
                for (int w = radius; w < qByteIMG.GetLength(2) - radius; w++)
                {
                    medianArea = new List<Pixel>();
                    for (int a = h - radius; a < h + radius + 1; a++)
                    {
                        for (int b = w - radius; b < w + radius + 1; b++)
                        {
                            medianArea.Add(pixels[a, b]);
                        }
                    }
                    medianArea.Sort();
                    /*
                    for (int a = h - radius; a < h + radius + 1; a++)
                    {
                        for (int b = w - radius; b < w + radius + 1; b++)
                        {
                            medianArea.Add(pixels[a,b]);
                        }
                    }
                    medianArea.Sort();*/
                    /*int k = 0;
                    for (int a = h - radius; a < h + radius + 1; a++)
                    {
                        for (int b = w - radius; b < w + radius + 1; b++)
                        {
                            qByteIMG[0, a, b] = medianArea[k].R;
                            qByteIMG[1, a, b] = medianArea[k].G;
                            qByteIMG[2, a, b] = medianArea[k].B;
                            k++;
                        }
                    }*/

                    qByteIMG[0, h, w] = medianArea[(medianArea.Count / 2) ].R;
                    qByteIMG[1, h, w] = medianArea[(medianArea.Count / 2) ].G;
                    qByteIMG[2, h, w] = medianArea[(medianArea.Count / 2) ].B;
                }
            }
            return bitmapConverter.rgbToBitmapQ(qByteIMG);
        }
    }

    public class Comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return Convert.ToInt32(((Pixel)(x)).Equals(y));
        }
    }

    public class RComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Pixel)(x)).R - ((Pixel)(y)).R;
        }
    }

    public class GComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Pixel)(x)).G - ((Pixel)(y)).G;
        }
    }

    public class BComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Pixel)(x)).B - ((Pixel)(y)).B;
        }
    }
}
