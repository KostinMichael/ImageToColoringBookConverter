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
    }
}
