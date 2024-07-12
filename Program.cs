using Microsoft.VisualBasic;
using System.Diagnostics;

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
            Application.Run(new MainForm());
        }


        // Считывание файла
        public static string read_file(string fileName)
        {
            string contents = "";

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                contents = File.ReadAllText(filePath);
            }

            return contents;
        }

        // Замена текста файла
        public static void update_file_contents(string fileName, string newContent)
        {
            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, newContent);
            }
        }

        // Замена имени файла
        public static void update_file_name(string oldFileName, string newFileName)
        {
            string filePath = $@"{NOTES_LOCATION}\{oldFileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(filePath, $"{newFileName}.{NOTE_FILE_EXTENTION}");
            }
        }

        // Создание нового файла
        public static void create_note_file(string fileName)
        {
            string filePath = $"{NOTES_LOCATION}\\{fileName}.{NOTE_FILE_EXTENTION}";
            using (File.Create(filePath)) { };
        }


        // Получение списка имён файлов
        public static List<string> get_notes_filenames()
        {
            List<string> notesFilenames = new List<string>();

            string[] files = Directory.GetFiles(NOTES_LOCATION);
            foreach(string file in files)
            {
                notesFilenames.Add(Path.GetFileNameWithoutExtension(file));
            }

            return notesFilenames;
        }

        // Открытие папки с заметками в проводнике
        public static void open_notes_location()
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = (NOTES_LOCATION + Path.DirectorySeparatorChar),
                UseShellExecute = true,
                Verb = "open"
            });
        }


        private static readonly string NOTES_LOCATION = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SecureNotesApp_test";
        private static readonly string NOTE_FILE_EXTENTION = "txt";
    }
}