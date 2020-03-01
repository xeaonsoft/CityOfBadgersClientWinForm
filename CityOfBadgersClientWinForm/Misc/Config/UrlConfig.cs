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
  
    public class UrlConfig
    {
        public string WebSiteUrl { get; set; }
        public string ValidateTokenRoute { get; set; }
        public string PublishRoute { get; set; }



        public static string Build(string route, string data)
        {
            return UrlConfig.Instance.WebSiteUrl + "/" + string.Format(route, data);
        }
        public static string Build(string route)
        {
            return UrlConfig.Instance.WebSiteUrl + "/" + route;
        }


        public static UrlConfig Instance = Load();

     
        public static UrlConfig Load()
        {

            string fileName = GetFileName();
            string jsonContent = null;
            if (File.Exists(fileName))
                jsonContent = File.ReadAllText(fileName);
            else
                jsonContent = RessourcesReader.TextFileRessourceToString(Properties.Resources.UrlConfig);

            UrlConfig instance = JsonConvert.DeserializeObject<UrlConfig>(jsonContent);

            instance.Save();

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
            return IO.GetRoamingFilePath("UrlConfig.json");
        }
    }
}
