using System.IO;

namespace PlanSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists("Database"))
            {
                Directory.CreateDirectory("Database");
            }
            Thread.CurrentThread.CurrentUICulture = new("ps-AF");
            Thread.CurrentThread.CurrentCulture = new("ps-AF");
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}