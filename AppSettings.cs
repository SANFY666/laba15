using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba15
{
    public class AppSettings
    {
        private const string SettingsFile = "settings.txt";

        public string Host { get; set; } = "ftp://192.168.0.103/";
        public string Username { get; set; } = "user";
        public string Password { get; set; } = "1111";

        // Зберігаємо налаштування у текстовий файл
        public void Save()
        {
            string[] lines = { Host, Username, Password };
            File.WriteAllLines(SettingsFile, lines);
        }

        // Завантажуємо налаштування з текстового файлу
        public void Load()
        {
            if (File.Exists(SettingsFile))
            {
                string[] lines = File.ReadAllLines(SettingsFile);
                if (lines.Length >= 3)
                {
                    Host = lines[0];
                    Username = lines[1];
                    Password = lines[2];
                }
            }
        }
    }
}
