using System;
using System.ComponentModel;
using CBIC.Core;
using СoloringBookImageConverter.Common;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter.Presenters {
    class MainPresenter : IPresenter {
        private readonly IMainView _mainForm;
        private readonly ImageProcessor _imageProcessor;
        private readonly BackgroundWorker _bwImageProcess = new BackgroundWorker();
        public MainPresenter(IMainView view) {
            _mainForm = view;
            _mainForm.ImagePathChanged += ImagePathChanged;
            _mainForm.ProcessImage += ProcessImage;
            _mainForm.PaletteSizeChanged += PaletteSizeChanged;
            /*mainForm.BlurDegreeChanged += BlurDegreeChanged;
            mainForm.LineThicknessChanged += LineThicknessChanged;
            mainForm.MinSquareChanged += MinSquareChanged;*/
            _bwImageProcess.DoWork += DoWorkProcessImage;
            _bwImageProcess.RunWorkerCompleted += ViewImageUpdate;
            _imageProcessor = new ImageProcessor(_mainForm);
            _mainForm.SetPaletteMaxSize(_imageProcessor.ConventMaxPaletteSize);
        }
        public void PaletteSizeChanged(Object sender, TrackBarEventArgs e)
        {
            _imageProcessor.ConventPaletteSize = e.Value;
            _mainForm.SetPaletteSizeInfo(_imageProcessor.RealPaletteSize);
        }
        public void ProcessImage(object sender, EventArgs e) {
            _bwImageProcess.RunWorkerAsync();
        }
        private void DoWorkProcessImage(object sender, DoWorkEventArgs e) {
            _mainForm.BlockElements();
            _imageProcessor.ProcessImage();
            _mainForm.UnBlockElements();
        }
        public void ImagePathChanged(Object sender, ImagePathEventArgs e) {
            _imageProcessor.UpdateImage(e.FilePath);
            _bwImageProcess.RunWorkerAsync();
        }
        public void Run() {
            _mainForm.Showy();
        }
        private void ViewImageUpdate(object obj, RunWorkerCompletedEventArgs args) {
            _mainForm.SetOriginalImage(_imageProcessor.OriginalImg);
            _mainForm.SetSimplifiedImage(_imageProcessor.SimpleImg);
            _mainForm.SetResultImage(_imageProcessor.ResultImg);
        }
        /*public void MinSquareChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new ArgumentException("'MinSquareChanged' value cannot be zero");
            }
            minSquare = e.Value;
        }
        public void LineThicknessChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 1) {
                throw new ArgumentException("'LineThickness' value cannot be zero");
            }
            lineThickness = e.Value;
        }
        public void BlurDegreeChanged(Object sender, TrackBarEventArgs e) {
            if (e.Value < 0) {
                throw new ArgumentException("'blur' value cannot be negative");
            }
            blurDegree = e.Value;
        }*/
    }
}
