using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotesApp
{
    internal class FileWork
    {
        // Считывание файла
        public static byte[] read_file(string fileName)
        {
            string NOTE_FILE_EXTENTION = Program.config.get_extention();
            string NOTES_LOCATION = Program.config.get_location();

            byte[] encryptedContents = { };

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                encryptedContents = File.ReadAllBytes(filePath);
            }

            return encryptedContents;
        }

        // Замена текста файла
        public static void update_file_contents(string fileName, byte[] encryptedContents)
        {
            string NOTE_FILE_EXTENTION = Program.config.get_extention();
            string NOTES_LOCATION = Program.config.get_location();

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";

            if (File.Exists(filePath))
            {

                File.WriteAllBytes(filePath, encryptedContents);
            }

        }

        // Замена имени файла
        public static void update_file_name(string oldFileName, string newFileName)
        {
            if (newFileName != oldFileName)
            {
                string NOTE_FILE_EXTENTION = Program.config.get_extention();
                string NOTES_LOCATION = Program.config.get_location();

                string filePath = $@"{NOTES_LOCATION}\{oldFileName}.{NOTE_FILE_EXTENTION}";

                if (File.Exists(filePath))
                {
                    Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(filePath, $"{newFileName}.{NOTE_FILE_EXTENTION}");
                }
            }
        }

        // Создание нового файла
        public static void create_note_file(string fileName, byte[] encryptedContents)
        {
            string NOTE_FILE_EXTENTION = Program.config.get_extention();
            string NOTES_LOCATION = Program.config.get_location();


            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            using (File.Create(filePath)) { };
            update_file_contents(fileName, encryptedContents); // записывание зашифрованного пароля в пустой файл
        }

        // Удаление файла
        public static void delete_note_file(string fileName)
        {
            string NOTE_FILE_EXTENTION = Program.config.get_extention();
            string NOTES_LOCATION = Program.config.get_location();

            string filePath = $@"{NOTES_LOCATION}\{fileName}.{NOTE_FILE_EXTENTION}";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }


        // Получение списка имён файлов
        public static List<string> get_notes_filenames()
        {
            
            string NOTES_LOCATION = Program.config.get_location();

            List<string> notesFilenames = new List<string>();

            string[] files = Directory.GetFiles(NOTES_LOCATION);
            foreach (string file in files)
            {
                notesFilenames.Add(Path.GetFileNameWithoutExtension(file));
            }

            return notesFilenames;
        }

        // Открытие папки с заметками в проводнике
        public static void open_notes_location()
        {
            
            string NOTES_LOCATION = Program.config.get_location();

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = (NOTES_LOCATION + Path.DirectorySeparatorChar),
                UseShellExecute = true,
                Verb = "open"
            });
        }


        // Проверка пути к директории
        public static void check_path(string path)
        {
            if (path == "")
            {
                throw new ArgumentException("Поле не может быть пустым");
            }

            if (File.Exists(path))
            {
                throw new ArgumentException("Путь должен указывать на директорию");
            }
            else if (!Directory.Exists(path))
            {
                throw new ArgumentException("Путь не существует");
            }
        }
    }
}
