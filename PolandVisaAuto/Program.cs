using System;
using System.Diagnostics;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

namespace PolandVisaAuto
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
                Logger.Info("");
                Logger.Info("=========================================Program started=====================================");
                Logger.Info("");
                Application.Run(new PVAutoFill());
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MyHandler(null, null);
            }
        }

        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Logger.Error((Exception)args.ExceptionObject);
            rerunApp();
        }
        // Handle the UI exceptions by showing a dialog box, and asking the user whether 
        // or not they wish to abort execution. 
        private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            Logger.Error(t.Exception);
            rerunApp();
        }

        private static void rerunApp()
        {
            Thread.Sleep(10000);
            Process.Start("PolandVisaAuto.exe");
            Application.Exit();
        }
    }
}
