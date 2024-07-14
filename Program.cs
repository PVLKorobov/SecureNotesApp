using Microsoft.VisualBasic;
using System.Configuration;
using System.Diagnostics;
using System.IO;

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
            // Create configuration object
            config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // Create default config if it doesn't exist
            create_default_config_if_missing();

            // Create notes directory if it doesn't exist
            System.IO.Directory.CreateDirectory(config.AppSettings.Settings["NOTES_LOCATION"].Value);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }


        private static void create_default_config_if_missing()
        {
            if (config.AppSettings.Settings["NOTES_LOCATION"] == null)
            {
                config.AppSettings.Settings.Add("NOTES_LOCATION", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SecureNotesApp_test");
            }
            if (config.AppSettings.Settings["NOTE_FILE_EXTENTION"] == null)
            {
                config.AppSettings.Settings.Add("NOTE_FILE_EXTENTION", "txt");
            }
            config.Save(ConfigurationSaveMode.Modified);
        }

        // ���������� �����
        public static byte[] read_file(string fileName)
        {
            string NOTE_FILE_EXTENTION = config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            byte[] encryptedContents = { };

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                encryptedContents = File.ReadAllBytes(filePath);
            }

            return encryptedContents;
        }

        // ������ ������ �����
        public static void update_file_contents(string fileName, byte[] encryptedContents)
        {
            string NOTE_FILE_EXTENTION = config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";

            if (File.Exists(filePath))
            {
                
                File.WriteAllBytes(filePath, encryptedContents);
            }
            
        }

        // ������ ����� �����
        public static void update_file_name(string oldFileName, string newFileName)
        {
            string NOTE_FILE_EXTENTION = config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            string filePath = $@"{NOTES_LOCATION}\{oldFileName}.{NOTE_FILE_EXTENTION}";
            
            if (File.Exists(filePath))
            {
                Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(filePath, $"{newFileName}.{NOTE_FILE_EXTENTION}");
            }
        }

        // �������� ������ �����
        public static void create_note_file(string fileName, byte[] encryptedContents)
        {
            string NOTE_FILE_EXTENTION = config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;


            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            using (File.Create(filePath)) { };
            update_file_contents(fileName, encryptedContents); // ����������� �������������� ������ � ������ ����
        }

        // �������� �����
        public static void delete_note_file(string fileName)
        {
            string NOTE_FILE_EXTENTION = config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }


        // ��������� ������ ��� ������
        public static List<string> get_notes_filenames()
        {
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            List<string> notesFilenames = new List<string>();

            string[] files = Directory.GetFiles(NOTES_LOCATION);
            foreach(string file in files)
            {
                notesFilenames.Add(Path.GetFileNameWithoutExtension(file));
            }

            return notesFilenames;
        }

        // �������� ����� � ��������� � ����������
        public static void open_notes_location()
        {
            string NOTES_LOCATION = config.AppSettings.Settings["NOTES_LOCATION"].Value;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = (NOTES_LOCATION + Path.DirectorySeparatorChar),
                UseShellExecute = true,
                Verb = "open"
            });
        }


        // �������� ���� � ����������
        private static void check_path(string path)
        {
            if (path == "")
            {
                throw new ArgumentException("���� �� ����� ���� ������");
            }

            if (File.Exists(path))
            {
                throw new ArgumentException("���� ������ ��������� �� ����������");
            }
            else if (!Directory.Exists(path))
            {
                throw new ArgumentException("���� �� ����������");
            }
        }


        // ���� � ���������� getter
        public static string get_location()
        {
            return config.AppSettings.Settings["NOTES_LOCATION"].Value;
        }

        // ���� � ���������� setter
        public static void set_location(string path)
        {
            check_path(path);
            config.AppSettings.Settings["NOTES_LOCATION"].Value = path;
            config.Save(ConfigurationSaveMode.Modified);
        }

        // ���������� ������ getter
        public static string get_extention()
        {
            return config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
        }

        // ���������� ������ setter
        public static void set_extention(string extention)
        {
            config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value = extention;
            config.Save(ConfigurationSaveMode.Modified);
        }


        private static Configuration config;
    }
}