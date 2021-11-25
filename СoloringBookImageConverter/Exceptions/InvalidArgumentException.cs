using System;

namespace СoloringBookImageConverter.Exceptions {
    class InvalidArgumentException : Exception{
        public InvalidArgumentException() : base() { }
        public InvalidArgumentException(string message) : base(message) { }
        public InvalidArgumentException(string message, Exception inner) : base(message, inner) { }

    }
}
