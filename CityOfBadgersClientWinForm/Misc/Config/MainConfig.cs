using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;

namespace CityOfBadgersClientTool
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
            string fileName = GetFileName();
            string jsonContent = null;
            if (File.Exists(fileName))
                jsonContent = File.ReadAllText(fileName);
            else
                jsonContent = RessourcesReader.TextFileRessourceToString(Properties.Resources.MainConfig);

            MainConfig instance = JsonConvert.DeserializeObject<MainConfig>(jsonContent);
            return instance;
        }


        public void Save()
        {
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }

        private static string GetFileName()
        {
            return IO.GetRoamingFilePath("MainConfig.json");
        }
    }
}
