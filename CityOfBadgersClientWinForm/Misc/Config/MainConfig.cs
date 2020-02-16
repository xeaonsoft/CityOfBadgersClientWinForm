using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;

namespace CityOfBadgersClientWinForm
{
    public class AccountData
    {
        public string LogFileFolder { get; set; }
        public string Name { get; set; }
    }
    public class MainConfig
    {
        public string LogFileFolder { get; set; }
        public string LogFilePath { get; set; }
        public AccountData SelectedAccount { get; set; }


        public string ClientToken { get; set; }


        public static MainConfig Instance = Load();

        public static MainConfig Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                MainConfig instance = JsonConvert.DeserializeObject<MainConfig>(jsonContent);
                return instance;
            }
            else
            {
                return new MainConfig();
            }

        }


        public void Save()
        {
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }

        private static string GetFileName()
        {
            string rootFolder = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
            string configFolder = Path.Combine(rootFolder, "ConfigFiles");
            if (!Directory.Exists(configFolder))
                Directory.CreateDirectory(configFolder);
            return Path.Combine(configFolder, "MainConfig.json");
        }
    }
}
