using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using CBIC.Common;

namespace CBIC.Quantizers
{
    /// <summary>
    /// Format24bppRgb
    /// </summary>
    public class WeightedAverageQuantizer : IQuantizer
    {
        public Bitmap GetSimplifiedImg(Bitmap img, MajorColor majorColor, byte conventPaletteSize, INotifier notifier)
        {
            MetaPixel[] metaPixels = BitmapToMetaPixels(img);
            metaPixels = QuantizeMetaPixels(metaPixels, conventPaletteSize, majorColor, notifier);
            return MetaPixelsToBitmap(metaPixels, img.Width, img.Height);
        }
        private unsafe MetaPixel[] BitmapToMetaPixels(Bitmap img)
        {
            MetaPixel[] mPixels = new MetaPixel[img.Width * img.Height];
            BitmapData bd = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try
            {
                int k = 0;
                for (int h = 0; h < img.Height; h++)
                {
                    byte* curpos = ((byte*)bd.Scan0) + (h * bd.Stride);
                    for (int w = 0; w < img.Width; w++)
                    {
                        byte b = *(curpos++);
                        byte g = *(curpos++);
                        byte r = *(curpos++);
                        mPixels[k++] = new MetaPixel(r, g, b, h, w);
                    }
                }
            }
            finally
            {
                img.UnlockBits(bd);
            }
            return mPixels;
        }
        private MetaPixel[] QuantizeMetaPixels(MetaPixel[] metaPixels, byte conventPaletteSize,
            MajorColor majorColor, INotifier notifier)
        {
            notifier.SetupProgress(3, 1);
            //Кол-во "кусочков" для резки rgb куба. Трекбар должен начинаться от нуля.
            //Кусочки: 4 5 6 7 8 9 10 == кол-ву цветов в палитре: 2 4 8 12 18 27 36
            int rgBpices = 4 + conventPaletteSize;
            //сколько раз по кругу резать r g b при N шагах (палитра 2^n)
            int[] rgbDividers = {
                metaPixels.Length / ((rgBpices / 3) + (((rgBpices % 3) + 1) / 2)),
                metaPixels.Length / ((rgBpices / 3) + (((rgBpices % 3) + 1) / 3)),
                metaPixels.Length / (rgBpices / 3)
            };
            //циклический сдвиг значений вправо, если опроный цвет второй или третий
            int[] dividingSteps = {
                rgbDividers[ (byte)majorColor],
                rgbDividers[((byte)majorColor + 1) % 3],
                rgbDividers[((byte)majorColor + 2) % 3]
            };
            ColorHolder avrgColor = new ColorHolder();
            long sumWeight = 0, numerator = 0;
            for (int colorIndex = 0; colorIndex < 3; colorIndex++)
            { //r g b
                Array.Sort(metaPixels, new RGBComparer(colorIndex));
                for (int i = 0; i < metaPixels.Length; i++)
                {
                    metaPixels[i].RGBbuf[colorIndex] = avrgColor; //кинул ссылку на цвет в rgbbuffer
                    numerator += metaPixels[i].RGB[colorIndex]; //числитель есть индекс цвета * частоту т.е. {17*2 + 18*2} = {17 + 17 + 18 +18}
                    sumWeight++; //сумма частот т.е. {17,17,18,18} = 4
                    if (sumWeight == dividingSteps[colorIndex] || i == metaPixels.Length - 1)
                    {
                        int weightedAverage = (int)(numerator / sumWeight);
                        if (weightedAverage > byte.MaxValue)
                        {
                            throw new InvalidCastException("Integer to Byte conversion overflow: " + weightedAverage);
                        }
                        avrgColor.Clr = (byte)weightedAverage; //все метапиксели, хранящие эту ссылку получают цвет
                        avrgColor = new ColorHolder(); //отсоединяю ссылку
                        sumWeight = numerator = 0;
                    }
                }
                notifier.ProgressStep();
            }
            return metaPixels;
        }
        private unsafe Bitmap MetaPixelsToBitmap(MetaPixel[] metaPixels, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bd = bitmap.LockBits(
                new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            try
            {
                foreach (MetaPixel metaPixel in metaPixels)
                {
                    byte* curpos = (metaPixel.WidthPos * 3) + (((byte*)bd.Scan0) + (metaPixel.HeightPos * bd.Stride));
                    *(curpos++) = metaPixel.RGBbuf[2].Clr; //Blue
                    *(curpos++) = metaPixel.RGBbuf[1].Clr; //Green
                    *(curpos) = metaPixel.RGBbuf[0].Clr; //Red
                }
            }
            finally
            {
                bitmap.UnlockBits(bd);
            }
            return bitmap;
        }
        public byte PaletteSize(byte conventPaletteSize)
        {
            int triple = (conventPaletteSize + 4) / 3;
            int mod = ((conventPaletteSize + 4) % 3) + 1;
            return (byte)((triple + (mod / 2)) * (triple + (mod / 3)) * triple);
        }
        class RGBComparer : IComparer<MetaPixel>
        {
            private readonly int _colorIndex;
            public RGBComparer(int colorIndex)
            {
                _colorIndex = colorIndex;
            }
            public int Compare(MetaPixel x, MetaPixel y)
            {
                if (x == null)
                {
                    throw new ArgumentNullException(nameof(x));
                }
                if (y == null)
                {
                    throw new ArgumentNullException(nameof(y));
                }
                return x.RGB[_colorIndex] - y.RGB[_colorIndex];
            }
        }
    }
}
