using System;
using СoloringBookImageConverter.Exceptions;

namespace СoloringBookImageConverter.UI {
    public class TrackBarEventArgs : EventArgs{
        public int Value { get; }

        public TrackBarEventArgs(int value) {
            Value = value;
        }
    }
}
