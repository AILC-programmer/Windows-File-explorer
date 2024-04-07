using System;
using System.Threading;
using System.Windows.Forms;

namespace Explorer
{
    internal static class Program
    {
        private static Mutex mutex;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string mutexName = "FileExplorerApplication";
            bool createdNew;
            mutex = new Mutex(true, mutexName, out createdNew);

            if (!createdNew)
            {
                Extentions.MessageBox.Run("The application is already running", "Run time error", "", "OK");
                return;
            }

            Application.Run(new MainExplorer());
        }
    }
}
