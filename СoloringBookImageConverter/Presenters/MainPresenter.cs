using System;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter.Presenters{
    class MainPresenter : IPresenter {
        private IMainView mainForm;

        public MainPresenter(IMainView view) {
            view.ImagePathChanged += new EventHandler<ImagePathEventArgs>(ImagePathChanged);
            this.mainForm = view;
        }

        public void Run() {
            mainForm.Showy();
        }

        public static void ImagePathChanged(Object sender, ImagePathEventArgs e)
        {
            string s = e.FilePath;
        }
    }
}
