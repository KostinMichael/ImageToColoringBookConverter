using System.Drawing;
using CBIC.Common;

namespace CBIC.Quantizers {
    /// <summary>
    /// Simplifies palette of image to several colors
    /// </summary>
    /// <seealso cref="CBIC.Quantizers.IPaletteSizeHolder" />
    public interface IQuantizer : IPaletteSizeHolder {
        Bitmap GetSimplifiedImg(Bitmap img, MajorColor majorColor, INotifier notifier);
    }
}