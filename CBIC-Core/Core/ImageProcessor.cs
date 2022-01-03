using System;
using System.Drawing;
using CBIC.Common;
using CBIC.Filters;
using CBIC.Quantizers;
namespace CBIC.Core
{
    public class ImageProcessor : IPaletteSizeHolder
    {
        private Bitmap _originalImg, _simpleImg, _resultImg;
        private readonly INotifier _notifier;
        private readonly IQuantizer _quantizer;
        private readonly IFilter _simpleEdger;
        private readonly IFilter _paletteExtractor;
        private byte _conventPaletteSize;
        public byte MaxConventPaletteSize => 6;
        /// <summary>
        /// SetConventPaletteSize [0, 1, 2... max] equal PaletteSize [2, 4, 8, 12, 18, 27, 36]
        /// </summary>
        public byte RealPaletteSize => _quantizer.PaletteSize(_conventPaletteSize);
        public Bitmap OriginalImg
        {
            get => _originalImg;
            set => _originalImg = _simpleImg = _resultImg = value;
        }
        public Bitmap SimpleImg => _simpleImg;
        public Bitmap ResultImg => _resultImg;
        public ImageProcessor(INotifier notifier)
        {
            _notifier = notifier;
            _quantizer = new WeightedAverageQuantizer();
            _simpleEdger = new SimpleEdger();
            _paletteExtractor = new PaletteExtractor();
        }

        public void ProcessImage()
        {
            if (_originalImg != null)
            {
                //todo create trackbar for selecting major color
                _simpleImg = _quantizer.GetSimplifiedImg(_originalImg, MajorColor.R, _conventPaletteSize, _notifier); 
                _resultImg = _simpleEdger.FilteredImg(SimpleImg, _notifier);
                //todo create picturebox for palette image
                //_resultImg = _paletteExtractor.FilteredImg(_simpleImg, _notifier); 
            }
        }
        public void UpdateImage(string imagePath)
        {
            try
            {
                _originalImg = new Bitmap(imagePath);
            }
            catch (Exception e)
            {
                _notifier.ShowMessage("Error opening file!\n\n" + e.Message + "\n\n" + imagePath);
            }
        }
        public void SetConventPaletteSize(byte conventPaletteSize)
        {
            _conventPaletteSize = conventPaletteSize;
        }
    }
}