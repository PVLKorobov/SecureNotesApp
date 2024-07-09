namespace SecureNotesApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create notes directory if it doesn't exist
            System.IO.Directory.CreateDirectory(NOTES_LOCATION);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


        public static string read_file(string fileName)
        {
            string contents = "";

            string filePath = $"{NOTES_LOCATION}\\{fileName}.txt";
            if (File.Exists(filePath))
            {
                contents = File.ReadAllText(filePath);
            }

            return contents;
        }


        private static readonly string NOTES_LOCATION = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SecureNotesApp_test";
    }
}