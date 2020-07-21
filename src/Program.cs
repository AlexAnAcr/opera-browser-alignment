using System;
using System.Windows.Forms;

namespace V1R1_BrowserAlign
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool runned;
            System.Threading.Mutex nmp = new System.Threading.Mutex(true, "{bcf3d923-321d-44ca-94f7-15f2e7d5304a}", out runned);
            if (runned)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            else
            {
                MessageBox.Show("Невозможно запустить более одного экземпляра программы!", "Ошибка");
            }
        }
    }
}
