using System;
using System.Windows.Forms;
using СoloringBookImageConverter.Presenters;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainPresenter main = new MainPresenter(new MainForm());
            main.Run();
        }
    }
}
