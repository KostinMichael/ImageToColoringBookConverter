using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using CBIC.Common;

namespace CBIC.Filters {
    public class PaletteExtractor : IFilter {
        public unsafe Bitmap FilteredImg(Bitmap img, INotifier notifier) {
            List<byte[]> palettePixs = PalettePixelsFromImage(img);
            palettePixs.Sort(new RGBComparer());
            int paletteSize = palettePixs.Count, height = 5, width = height * paletteSize;
            Bitmap paletteImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bd = paletteImage.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            try {
                int step = width / paletteSize;
                for (int h = 0; h < height; h++) {
                    byte* curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                    for (int w = 0; w < width; w++) {
                        //(w/step) - это определение индекса, находится ли сейчас пиксель
                        //в зоне N-го цвета палитры, где ширина зоны определяется как step = imgWidth / paletteSize;
                        *(curpos++) = palettePixs[w / step][2];
                        *(curpos++) = palettePixs[w / step][1];
                        *(curpos++) = palettePixs[w / step][0];
                    }
                }
            } finally {
                paletteImage.UnlockBits(bd);
            }
            return paletteImage;
        }

        private unsafe List<byte[]> PalettePixelsFromImage(Bitmap img) {
            List<byte[]> pixels = new List<byte[]>();
            BitmapData bd = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            try {
                for (int h = 0; h < img.Height; h++) {
                    byte* curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                    for (int w = 0; w < img.Width; w++) {
                        byte b = *(curpos++);
                        byte g = *(curpos++);
                        byte r = *(curpos++);
                        byte[] pixel = { r, g, b };
                        if (!pixels.Any(x => x.SequenceEqual(pixel))) pixels.Add(pixel);
                    }
                }
            } finally {
                img.UnlockBits(bd);
            }
            return pixels;
        }
        /// <summary>
        /// Comparison of two colors by gray scale
        /// </summary>
        class RGBComparer : IComparer<byte[]> {
            public int Compare(byte[] x, byte[] y)
            {
                if(x == null | y == null) throw new NullReferenceException();
                return ((x[0] + x[1] + x[2]) / 3) - ((y[0] + y[1] + y[2]) / 3);
            }
        }
    }
}
