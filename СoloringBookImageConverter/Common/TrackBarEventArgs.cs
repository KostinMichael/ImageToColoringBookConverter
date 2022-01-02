using System;

namespace СoloringBookImageConverter.Common {
    public class TrackBarEventArgs : EventArgs {
        public byte Value { get; }
        public TrackBarEventArgs(int value) {
            if (value <= byte.MaxValue && value >= 0) {
                Value = (byte)value;
            } else throw new ArgumentException("out of byte range");
        }
        public TrackBarEventArgs(byte value) {
            Value = value;
        }
    }
}
