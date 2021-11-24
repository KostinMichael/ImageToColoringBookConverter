using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using СoloringBookImageConverter.Controllers;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter.Presenters {
    class MainPresenter : IPresenter {
        private IMainView mainForm;
        private Painter painter;
        private string imagePath = "";
        public MainPresenter(IMainView view) {
            view.ImagePathChanged += new EventHandler<ImagePathEventArgs>(ImagePathChanged);
            view.ProcessImage += new EventHandler(ProcessImage);
            this.mainForm = view;
            painter = new Painter(200, 25, 16);
        }

        private void View_ProcessImage(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        public void Run() {
            mainForm.Showy();
        }

        public void ImagePathChanged(Object sender, ImagePathEventArgs e) {
            if (File.Exists(e.FilePath)) {
                imagePath = e.FilePath;
                mainForm.SetOriginalImage(new Bitmap(imagePath));
            } else {
                mainForm.ShowErrorMessage("select image first!");
            }
        }

        public void ProcessImage(Object sender, EventArgs e) {
            if (File.Exists(imagePath)) {
                BackgroundWorker backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += DoWork;
                backgroundWorker.RunWorkerAsync();
                backgroundWorker.RunWorkerCompleted += delegate {
                    mainForm.SetResultImage(painter.getEdgesBitmap());
                    mainForm.SetSimplifiedImage(painter.getQuantizeBitmap());
                    //todo: pictureBoxEdges.Image = painter.GetMedianImage(10);
                };
                //Thread threadGravity = new Thread(() => painter.makeEdgesImage(new Bitmap("med.png"), 0));
                //threadGravity.Start();
            } else {
                mainForm.ShowErrorMessage("select image first!");
            }
        }

        private void DoWork(object sender, DoWorkEventArgs e) {
            var worker = sender as BackgroundWorker;
            e.Result = e.Argument;
            painter.makeEdgesImage(new Bitmap(imagePath), 0);
        }
    }
}
