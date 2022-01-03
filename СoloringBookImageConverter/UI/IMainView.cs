using System;
using System.Drawing;
using CBIC.Common;
using СoloringBookImageConverter.Common;

namespace СoloringBookImageConverter.UI {
    interface IMainView : IView{
        void SetOriginalImage(Bitmap bitmap);
        void SetSimplifiedImage(Bitmap bitmap);
        void SetResultImage(Bitmap bitmap);
        void SetPaletteMaxSize(int maxValue);
        void SetPaletteSizeInfo(int value);
        void BlockElements();
        void UnBlockElements();
        event EventHandler ProcessImage;
        event EventHandler<ImagePathEventArgs> ImagePathChanged;
        event EventHandler<TrackBarEventArgs> PaletteSizeChanged;
        event EventHandler<TrackBarEventArgs> BlurDegreeChanged;
        event EventHandler<TrackBarEventArgs> MinSquareChanged;
        event EventHandler<TrackBarEventArgs> LineThicknessChanged;
    }
}
