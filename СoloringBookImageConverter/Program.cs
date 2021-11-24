using СoloringBookImageConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using СoloringBookImageConverter.Presenters;
using СoloringBookImageConverter.UI;

namespace СoloringBookImageConverter
{
    static class Program
    {
        public static readonly ApplicationContext Context = new ApplicationContext();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
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
