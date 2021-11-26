 using System;
using System.Drawing;

namespace СoloringBookImageConverter.UI {
    interface IMainView : IView{
        void SetOriginalImage(Bitmap bitmap);
        void SetSimplifiedImage(Bitmap bitmap);
        void SetResultImage(Bitmap bitmap);
        void ShowErrorMessage(string errorMessage);
        event EventHandler ProcessImage;
        event EventHandler<ImagePathEventArgs> ImagePathChanged;
        event EventHandler<TrackBarEventArgs> BlurDegreeChanged;
        event EventHandler<TrackBarEventArgs> PaletteSizeChanged;
        event EventHandler<TrackBarEventArgs> MinSquareChanged;
        event EventHandler<TrackBarEventArgs> LineThicknessChanged;
        event EventHandler<TrackBarEventArgs> RedPCBDegree;
        event EventHandler<TrackBarEventArgs> GreenPCBDegree;
        event EventHandler<TrackBarEventArgs> BluePCBDegree;
    }
}
