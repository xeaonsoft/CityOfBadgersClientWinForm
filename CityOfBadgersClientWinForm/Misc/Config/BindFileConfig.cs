using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CityOfBadgersClientTool
{
    public class BindFileConfig
    {

        public string FolderPath { get; set; }
        public string BindText { get; set; }
        public int MaxValue { get; set; }
        public int ItemsPerFile { get; set; }

        public static BindFileConfig Instance = Load();

        public static BindFileConfig Load()
        {
            
            string fileName = GetFileName();
            string jsonContent = null;
            if (File.Exists(fileName))
                jsonContent = File.ReadAllText(fileName);
            else
                jsonContent = RessourcesReader.TextFileRessourceToString(Properties.Resources.BindFileConfig);

            BindFileConfig instance = JsonConvert.DeserializeObject<BindFileConfig>(jsonContent);
            instance.Validate();

            return instance;

        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(this.BindText))
                this.BindText = "ctrl+m";

            if (this.MaxValue <= 0 || this.MaxValue > 9999)
                this.MaxValue = 2500;

            if (this.ItemsPerFile <= 0 || this.ItemsPerFile > 50)
                this.ItemsPerFile = 12;
        }


        public static int TryParseInt(string input)
        {
            input = $"{input}".Trim();
            if (!string.IsNullOrEmpty(input))
            {
                int outValue;
                if (int.TryParse(input, out outValue))
                    return outValue;
            }
            return 0;
        }
        public void Save()
        {
            string saveFile = GetFileName();
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(saveFile, jsonContent);
        }



        private static string GetFileName()
        {
            return IO.GetRoamingFilePath("BindFileConfig.json");
        }
    }
}
