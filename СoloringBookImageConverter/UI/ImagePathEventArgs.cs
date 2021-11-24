using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СoloringBookImageConverter.UI {
    public class ImagePathEventArgs : EventArgs{
        public string FilePath { get; }

        public ImagePathEventArgs(string filePath)
        {
            FilePath = filePath;
        }
    }
}
