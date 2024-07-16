using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace SecureNotesApp
{
    internal static class Program
    {
        public static Config config;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create configuration object
            config = new Config();

            
            

            // Create notes directory if it doesn't exist
            System.IO.Directory.CreateDirectory(config.get_location());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }



    }
}