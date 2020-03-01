using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientTool
{
    public class IO
    {

        private static string GetRoamingFolder()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folder = Path.Combine(path, "City Of Badgers");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            return folder;
        }

        public static string GetRoamingFilePath(string name)
        {
            string folder = GetRoamingFolder();
            return Path.Combine(folder, name);
        }
    }
}
