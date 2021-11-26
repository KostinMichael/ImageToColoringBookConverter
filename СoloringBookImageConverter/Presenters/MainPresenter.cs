using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using СoloringBookImageConverter.Controllers;
using СoloringBookImageConverter.Exceptions;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter.Presenters {
    class MainPresenter : IPresenter {
        private readonly IMainView mainForm;
        private readonly Painter painter;
        private string imagePath = "";
        private int blurDegree = 0, paletteSize = 0, PCBr = 30, PCBg = 59, PCBb = 11, minSquare = 0, lineThickness = 0;
        public MainPresenter(IMainView view) {
            mainForm = view;
            mainForm.ImagePathChanged += ImagePathChanged;
            mainForm.ProcessImage += ProcessImage;
            mainForm.BlurDegreeChanged += BlurDegreeChanged;
            mainForm.PaletteSizeChanged += PaletteSizeChanged;
            mainForm.RedPCBDegree += RedPCBDegree;
            mainForm.GreenPCBDegree += GreenPCBDegree;
            mainForm.BluePCBDegree += BluePCBDegree;
            mainForm.LineThicknessChanged += LineThicknessChanged;
            mainForm.MinSquareChanged += MinSquareChanged;
            painter = new Painter(200, 25, 16);
        }

        public void Run() {
            mainForm.Showy();
        }
        public void MinSquareChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'MinSquareChanged' value cannot be zero");
            }
            minSquare = e.Value;
        }
        public void LineThicknessChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'LineThickness' value cannot be zero");
            }
            lineThickness = e.Value;
        }
        public void RedPCBDegree(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'RedPCBDegree' value cannot be zero");
            }
            PCBr = e.Value;
        }
        public void GreenPCBDegree(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'GreenPCBDegree' value cannot be zero");
            }
            PCBg = e.Value;
        }
        public void BluePCBDegree(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'BluePCBDegree' value cannot be zero");
            }
            PCBb = e.Value;
        }

        public void PaletteSizeChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new InvalidArgumentException("'paletteSize' value cannot be zero");
            }
            paletteSize = e.Value;
        }

        public void BlurDegreeChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 0) {
                throw new InvalidArgumentException("'blur' value cannot be negative");
            }
            blurDegree = e.Value;
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
