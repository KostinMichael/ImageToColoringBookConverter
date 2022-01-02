using System.Drawing;
using CBIC.Quantizers;

namespace CBIC.Core {
    public interface IProcessor {
        /// <summary>
        /// Gets original img.
        /// </summary>
        /// <value>
        /// The original img.
        /// </value>
        Bitmap OriginalImg { get; }
        /// <summary>
        /// Gets simple img.
        /// </summary>
        /// <value>
        /// The simple img.
        /// </value>
        Bitmap SimpleImg { get; }
        /// <summary>
        /// Gets result img.
        /// </summary>
        /// <value>
        /// The result img.
        /// </value>
        Bitmap ResultImg { get; }
        /// <summary>
        /// Gets Palette bridge.
        /// </summary>
        /// <value>
        /// The size of the palette.
        /// </value>
        IPaletteSizeHolder PaletteSize { get; }
        /// <summary>
        /// Updates image.
        /// </summary>
        /// <param name="imagePath">The image path.</param>
        void UpdateImage(string imagePath);
        /// <summary>
        /// Processes image.
        /// </summary>
        void ProcessImage();
    }
}
