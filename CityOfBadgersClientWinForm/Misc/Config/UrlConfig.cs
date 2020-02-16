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
  
    public class UrlConfig
    {
        public string WebSiteUrl { get; set; }
        public string ValidateTokenRoute { get; set; }
        public string PublishRoute { get; set; }



        public static string Build(string route, string data)
        {
            return UrlConfig.Instance.WebSiteUrl + "/" + string.Format(route, data);
        }



        public static UrlConfig Instance = Load();

        public static UrlConfig Load()
        {
            string saveFile = GetFileName();
            if (File.Exists(saveFile))
            {
                string jsonContent = File.ReadAllText(saveFile);
                UrlConfig instance = JsonConvert.DeserializeObject<UrlConfig>(jsonContent);
                return instance;
            }
            else
            {
                return new UrlConfig();
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
            return Path.Combine(configFolder, "UrlConfig.json");
        }
    }
}
