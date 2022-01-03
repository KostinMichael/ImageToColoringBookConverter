namespace CBIC.Core
{
    /// <summary>
    /// Bridge between conventional units of UI trackbar and quantizer units
    /// </summary>
    public interface IPaletteSizeHolder
    {
        /// <summary>
        /// Conventional units for trackbar (0, 1, 2..ConventMaxPaletteSize)
        /// </summary>
        void ConventPaletteSize(byte conventPaletteSize);
        /// <summary>
        /// Conventional units for Maximal trackbar value (0...ConventMaxPaletteSize)
        /// </summary>
        byte ConventMaxPaletteSize { get; }
        /// <summary>
        /// Internal units for the quantization algorithm.
        /// Typical used in trackbar info label
        /// </summary>
        byte RealPaletteSize { get; }
    }
}
