using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotesApp
{
    internal class Config
    {
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public Config()
        {
            create_default_config_if_missing();
        }


        private static Configuration create_default_config_if_missing()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (config.AppSettings.Settings["NOTES_LOCATION"] == null)
            {
                config.AppSettings.Settings.Add("NOTES_LOCATION", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\SecureNotesApp_test");
            }
            if (config.AppSettings.Settings["NOTE_FILE_EXTENTION"] == null)
            {
                config.AppSettings.Settings.Add("NOTE_FILE_EXTENTION", "txt");
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return config;
        }

        // Расширение файлов getter
        public string get_extention()
        {
            return config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value;
        }

        // Расширение файлов setter
        public void set_extention(string extention)
        {
            config.AppSettings.Settings["NOTE_FILE_EXTENTION"].Value = extention;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        // Путь к директории getter
        public string get_location()
        {
            return config.AppSettings.Settings["NOTES_LOCATION"].Value;
        }

        // Путь к директории setter
        public void set_location(string path)
        {
            FileWork.check_path(path);
            config.AppSettings.Settings["NOTES_LOCATION"].Value = path;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
