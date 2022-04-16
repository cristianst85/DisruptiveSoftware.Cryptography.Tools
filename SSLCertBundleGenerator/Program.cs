using SSLCertBundleGenerator.Commons;
using SSLCertBundleGenerator.Windows;
using System;
using System.Windows.Forms;

namespace SSLCertBundleGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            InternalMain(args);
        }

        private static void InternalMain(string[] args)
        {
            if (!EnvironmentUtils.IsUnix())
            {
                if (EnvironmentUtils.IsAtLeastWindows10())
                {
                    NativeMethods.SetProcessDpiAwareness(NativeMethods.ProcessDpiAwareness.ProcessPerMonitorDpiAware);
                }
                else if (EnvironmentUtils.IsAtLeastWindowsVista())
                {
                    NativeMethods.SetProcessDPIAware();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSSLCertBundleGenerator());
        }
    }
}
