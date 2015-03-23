using System;
using System.Diagnostics;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace PolandVisaMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain currentDomain = AppDomain.CurrentDomain;
            Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MyHandler(null, null);
            }
        }

        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Thread.Sleep(5000);
            Process.Start("PolandVisaMonitor.exe");
            Application.Exit();
        }
        // Handle the UI exceptions by showing a dialog box, and asking the user whether 
        // or not they wish to abort execution. 
        private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            MyHandler(null, null);
        }
    }
}
