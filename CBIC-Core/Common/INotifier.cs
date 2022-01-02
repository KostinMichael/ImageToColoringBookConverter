namespace CBIC.Common {
    public interface INotifier {
        void ShowMessage(string text);
        void SetupProgress(int maxValue, int step);
        void ProgressStep();
    }
}
