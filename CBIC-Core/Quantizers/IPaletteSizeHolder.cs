﻿namespace CBIC.Quantizers {
    /// <summary>
    /// Bridge between conventional units of UI trackbar and quantizer units
    /// </summary>
    public interface IPaletteSizeHolder {
        /// <summary>
        /// Conventional units for trackbar (0, 1, 2..ConventMaxPaletteSize)
        /// </summary>
        byte ConventPaletteSize { set;  }
        /// <summary>
        /// Conventional units for Maximal trackbar value (0...ConventMaxPaletteSize)
        /// </summary>
        byte ConventMaxPaletteSize { get; }
        /// <summary>
        /// Internal units for the quantization algorithm.
        /// Typicaly used in trackbar info label
        /// </summary>
        byte PaletteSize { get; }
    }
}