using System;
using System.Drawing;
using CBIC.Common;
using CBIC.Filters;
using CBIC.Quantizers;
namespace CBIC.Core {
    public class ImageProcessor : IProcessor {
        private Bitmap _originalImg, _simpleImg, _resultImg;
        private readonly INotifier _notifier;
        private readonly IQuantizer _quantizer;
        private readonly IFilter _simpleEdger;
        private readonly IFilter _paletteExtractor;
        /// <inheritdoc />
        public IPaletteSizeHolder PaletteSize => _quantizer;
        /// <inheritdoc />
        /// <summary>
        /// When new one image seted all other old will be replaced
        /// </summary>
        public Bitmap OriginalImg {
            get => _originalImg;
            set => _originalImg = _simpleImg = _resultImg = value;
        }
        /// <inheritdoc />
        public Bitmap SimpleImg => _simpleImg;
        /// <inheritdoc />
        public Bitmap ResultImg => _resultImg;
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageProcessor"/> class.
        /// </summary>
        /// <param name="notifier">Progress informer. For mocking just use DebugNotifie</param>
        /// <param name="quantizer">The quantizer.</param>
        /// <param name="simpleEdger">The simple edger.</param>
        /// <param name="paletteExtractor">The palette extractor.</param>
        public ImageProcessor(INotifier notifier, IQuantizer quantizer, IFilter simpleEdger, IFilter paletteExtractor) {
            _notifier = notifier;
            _quantizer = quantizer;
            _simpleEdger = simpleEdger;
            _paletteExtractor = paletteExtractor;
        }
        /// <inheritdoc />
        public void ProcessImage() {
            if (_originalImg != null) {
                _simpleImg = _quantizer.GetSimplifiedImg(_originalImg, MajorColor.R, _notifier); //todo create trackbar for selecting major color
                _resultImg = _simpleEdger.FilteredImg(SimpleImg, _notifier);
                //todo create picturebox for palette image
                //_resultImg = _paletteExtractor.FilteredImg(_simpleImg, _notifier); 
            }
        }
        /// <inheritdoc />
        public void UpdateImage(string imagePath) {
            try {
                _originalImg = new Bitmap(imagePath);
            } catch (Exception e) {
                _notifier.ShowMessage("Error opening file!\n\n" + e.Message + "\n\n" + imagePath);
            }
        }
    }
}