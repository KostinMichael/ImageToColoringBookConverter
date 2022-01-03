using System.Drawing;
using System.Drawing.Imaging;
using CBIC.Common;

namespace CBIC.Filters
{
    public class SimpleEdger : IFilter
    {
        /// <summary>
        /// Filtereds the img.
        /// </summary>
        /// <param name="bmp">The BMP.</param>
        /// <param name="notifier">The notifier.</param>
        /// <returns></returns>
        public unsafe Bitmap FilteredImg(Bitmap bmp, INotifier notifier)
        {
            int width = bmp.Width, height = bmp.Height;
            byte[,,] RGBHW = BitmapToRGBHW(bmp, width, height);
            notifier.SetupProgress(height - 2, 1);
            Bitmap result = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bd = result.LockBits(
                new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            try
            {
                fixed (byte* rgb = RGBHW)
                {
                    byte* r = rgb, g = rgb + width * height, b = rgb + 2 * width * height;
                    for (int h = 1; h < height - 1; h++)
                    {
                        for (int w = 1; w < width - 1; w++)
                        {
                            int right = (RGBHW[0, h, w] - RGBHW[0, h, w + 1])
                                        + (RGBHW[1, h, w] - RGBHW[1, h, w + 1])
                                        + (RGBHW[2, h, w] - RGBHW[2, h, w + 1]);
                            int left = (RGBHW[0, h, w] - RGBHW[0, h, w - 1])
                                        + (RGBHW[1, h, w] - RGBHW[1, h, w - 1])
                                        + (RGBHW[2, h, w] - RGBHW[2, h, w - 1]);
                            int top = (RGBHW[0, h, w] - RGBHW[0, h - 1, w])
                                      + (RGBHW[1, h, w] - RGBHW[1, h - 1, w])
                                      + (RGBHW[2, h, w] - RGBHW[2, h - 1, w]);
                            int bottom = (RGBHW[0, h, w] - RGBHW[0, h + 1, w])
                                         + (RGBHW[1, h, w] - RGBHW[1, h + 1, w])
                                         + (RGBHW[2, h, w] - RGBHW[2, h + 1, w]);
                            if (right + left + top + bottom == 0)
                            {
                                //текущий пиксель становится цветным если все вокруг похожи на него
                                byte* curpos = (w * 3) + (((byte*)bd.Scan0) + h * bd.Stride);
                                *(curpos++) = *(b + width * h + w);
                                *(curpos++) = *(g + width * h + w);
                                *(curpos) = *(r + width * h + w);
                            }
                        }
                        notifier.ProgressStep();
                    }
                }
            }
            finally
            {
                result.UnlockBits(bd);
            }
            return result;
        }
        private unsafe byte[,,] BitmapToRGBHW(Bitmap bmp, int width, int height)
        {
            byte[,,] RGBHW = new byte[3, height, width];
            BitmapData bd = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            try
            {
                fixed (byte* res = RGBHW)
                {
                    byte* r = res, g = res + width * height, b = res + 2 * width * height;
                    for (int h = 0; h < height; h++)
                    {
                        var curpos = ((byte*)bd.Scan0) + h * bd.Stride;
                        for (int w = 0; w < width; w++)
                        {
                            *b = *(curpos++);
                            ++b;
                            *g = *(curpos++);
                            ++g;
                            *r = *(curpos++);
                            ++r;
                        }
                    }
                }
            }
            finally
            {
                bmp.UnlockBits(bd);
            }
            return RGBHW;
        }
    }
}
