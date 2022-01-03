using System;

namespace СoloringBookImageConverter.Common
{
    public class ImagePathEventArgs : EventArgs
    {
        public string FilePath { get; }
        public ImagePathEventArgs(string filePath)
        {
            FilePath = filePath;
        }
    }
}
