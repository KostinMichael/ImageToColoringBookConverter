using System;
using System.Diagnostics;

namespace CBIC.Common {
    public class DebugNotifier : INotifier {
        private int _maxValue, _step, _value;
        public void ShowMessage(string text) {
            throw new NotImplementedException();
        }
        public void SetupProgress(int maxValue, int step) {
            _maxValue = maxValue;
            _step = step;
            _value = 0;
        }
        public void ProgressStep() {
            Debug.WriteLine("progress [{0}/{1}]", _value + _step, _maxValue);
        }
    }
}
