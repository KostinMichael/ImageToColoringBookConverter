using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using CBIC.Common;

namespace CBIC.Quantizers {
    /// <summary>
    /// Format24bppRgb
    /// </summary>
    public class WeightedAverageQuantizer : IQuantizer {
        private byte _conventPaletteSize;
        /// <inheritdoc />
        public byte ConventPaletteSize { set => _conventPaletteSize = value; }
        /// <inheritdoc />
        public byte ConventMaxPaletteSize => 6;
        /// <summary>
        /// ConventPaletteSize [0, 1, 2... max] == PaletteSize [2, 4, 8, 12, 18, 27, 36]
        /// </summary>
        public byte PaletteSize {
            get {
                int triple = (_conventPaletteSize + 4) / 3;
                int mod = (((_conventPaletteSize + 4) % 3) + 1);
                return (byte)((triple + (mod / 2)) * (triple + (mod / 3)) * triple);
            }
        }
        /// <summary>
        /// <param name="majorColor">
        ///     С какого цвета начнётся отсчёт {0, 1, 2}. При нечётном кол-ве кусочков третьему "недостанется" одного.
        ///     Например при _majorColor = 0 и 5 кусочкам, у R будет 2, у G будет 2, у B будет 1,
        /// </param> 
        /// </summary>
        public Bitmap GetSimplifiedImg(Bitmap img, MajorColor majorColor, INotifier notifier) {
            MetaPixel[] metaPixels = BitmapToMetaPixels(img);
            metaPixels = QuantizeMetaPixels(metaPixels, majorColor, notifier);
            return MetaPixelsToBitmap(metaPixels, img.Width, img.Height);
        }
        /// <summary>
        /// <param name="conventSize">условный размер палитры 0..maxSize</param>
        /// </summary>
        /// <returns>реальный размер палитры: 2^(n-3), где n = value + 4</returns> 
        private unsafe MetaPixel[] BitmapToMetaPixels(Bitmap img) {
            MetaPixel[] mPixels = new MetaPixel[img.Width * img.Height];
            BitmapData bd = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try {
                int k = 0;
                for (int h = 0; h < img.Height; h++) {
                    byte* curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                    for (int w = 0; w < img.Width; w++) {
                        byte b = *(curpos++);
                        byte g = *(curpos++);
                        byte r = *(curpos++);
                        mPixels[k++] = new MetaPixel(r, g, b, h, w);
                    }
                }
            } finally {
                img.UnlockBits(bd);
            }
            return mPixels;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metaPixels"></param>
        /// <param name="conventPaletteSize"></param>
        /// <param name="majorColor"></param>
        /// <param name="notifier"></param>
        /// <returns></returns>
        private MetaPixel[] QuantizeMetaPixels(MetaPixel[] metaPixels, MajorColor majorColor, INotifier notifier) {
            notifier.SetupProgress(3, 1);
            //Кол-во "кусочков" для резки rgb куба. Трекбар должен начинаться от нуля.
            //Кусочки: 4 5 6 7 8 9 10 == кол-ву цветов в палитре: 2 4 8 12 18 27 36
            int rgBpices = 4 + _conventPaletteSize;
            //сколько раз по кругу резать r g b при N шагах (палитра 2^n)
            int[] rgbDividers = {
                metaPixels.Length / (rgBpices / 3 + (((rgBpices % 3) + 1) / 2)),
                metaPixels.Length / (rgBpices / 3 + (((rgBpices % 3) + 1) / 3)),
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
            Debug.WriteLine("==============================");
            for (int colorIndex = 0; colorIndex < 3; colorIndex++) { //r g b
                Array.Sort(metaPixels, new RGBComparer(colorIndex));
                for (int i = 0; i < metaPixels.Length; i++) {
                    metaPixels[i].RGBbuf[colorIndex] = avrgColor; //кинул ссылку на цвет в rgbbuffer
                    numerator += metaPixels[i].RGB[colorIndex]; //числитель есть индекс цвета * частоту т.е. {17*2 + 18*2} = {17 + 17 + 18 +18}
                    //Debug.WriteLine("numerator=" + numerator + "  color=" + metaPixels[i].RGB[colorIndex]);
                    sumWeight++; //сумма частот т.е. {17,17,18,18} = 4
                    if (sumWeight == dividingSteps[colorIndex] | i == metaPixels.Length - 1) {
                        int weightedAverage = (int)(numerator / sumWeight);
                        if (weightedAverage > byte.MaxValue) throw new Exception("bad algorithm avrg color byte = " + weightedAverage);
                        avrgColor.Clr = (byte)weightedAverage; //все метапиксели, хранящие эту ссылку получают цвет
                        avrgColor = new ColorHolder(); //отсоединяю ссылку
                        sumWeight = numerator = 0;
                    }
                }
                Array.Sort(metaPixels, new RGBComparer(0));
                notifier.ProgressStep();
            }
            return metaPixels;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metaPixels"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private unsafe Bitmap MetaPixelsToBitmap(MetaPixel[] metaPixels, int width, int height) {
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bd = bitmap.LockBits(
                new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            try {
                foreach (MetaPixel metaPixel in metaPixels) {
                    byte* curpos = (metaPixel.WidthPos * 3) + (((byte*)bd.Scan0) + metaPixel.HeightPos * bd.Stride);
                    *(curpos++) = metaPixel.RGBbuf[2].Clr; //Blue
                    *(curpos++) = metaPixel.RGBbuf[1].Clr; //Green
                    *(curpos) = metaPixel.RGBbuf[0].Clr; //Red
                }
            } finally {
                bitmap.UnlockBits(bd);
            }
            return bitmap;
        }
        /// <summary>
        /// 
        /// </summary>
        class RGBComparer : IComparer<MetaPixel> {
            private readonly int _colorIndex;
            public RGBComparer(int colorIndex) {
                _colorIndex = colorIndex;
            }

            public int Compare(MetaPixel x, MetaPixel y) {
                int res = x.RGB[_colorIndex] - y.RGB[_colorIndex];
                int res2 = x.RGB[(_colorIndex + 1) % 3] - y.RGB[(_colorIndex + 1) % 3];
                int res3 = x.RGB[(_colorIndex + 2) % 3] - y.RGB[(_colorIndex + 2) % 3];
                return res == 0 ? (res2 == 0 ? res3 : res2) : res;
            }
        }
    }
}
