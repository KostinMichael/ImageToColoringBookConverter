using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using CBIC.Common;

namespace CBIC.Filters {
    public class PaletteExtractor : IFilter {
        /// <summary>
        /// Image filter.
        /// </summary>
        /// <param name="img">Filtered image.</param>
        /// <param name="notifier">Filtering process notifier.</param>
        /// <returns>Filtered image.</returns>
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
        /// <summary>
        /// Palettes the pixels from image.
        /// </summary>
        /// <param name="img">The img.</param>
        /// <returns></returns>
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
        /// Compares two colors on gray scale
        /// </summary>
        /// <seealso cref="System.Collections.Generic.IComparer&lt;System.Byte[]&gt;" />
        class RGBComparer : IComparer<byte[]> {
            public int Compare(byte[] x, byte[] y) {
                return ((x[0] + x[1] + x[2]) / 3) - ((y[0] + y[1] + y[2]) / 3);
            }
        }
    }
}
