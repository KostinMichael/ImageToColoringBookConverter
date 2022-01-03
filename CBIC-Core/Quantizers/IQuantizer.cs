using System.Drawing;
using CBIC.Common;

namespace CBIC.Quantizers {
    public interface IQuantizer : IPaletteUnitsConverter {
        Bitmap GetSimplifiedImg(Bitmap img, MajorColor majorColor, byte conventPaletteSize, INotifier notifier);
    }
}