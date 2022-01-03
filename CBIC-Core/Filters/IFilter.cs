using System.Drawing;
using CBIC.Common;

namespace CBIC.Filters
{
    public interface IFilter
    {
        Bitmap FilteredImg(Bitmap bmp, INotifier notifier);
    }
}
