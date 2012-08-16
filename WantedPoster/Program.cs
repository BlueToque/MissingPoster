using System;
using System.Windows.Forms;
using System.IO;
using BlueToque.Utility;
using MissingPoster.Properties;

namespace MissingPoster
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration.Load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
