using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm
{
    public class BinFileHandler
    {
        internal static void DeleteFiles(string bindPath)
        {

            string[] files = Directory.GetFiles(bindPath, "bind*.txt");
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch { }
            }
        }

        internal static void Generate(string bindPath)
        {
            int maxValue = BindFileConfig.Instance.MaxValue;
            string bindText = BindFileConfig.Instance.BindText;


            

            int fileCpt = 0;

            int itemsPerFiles = BindFileConfig.Instance.ItemsPerFile;

            for (int i = 0; i < maxValue; i += itemsPerFiles)
            {
                string currentFilePath = Path.Combine(bindPath, $"bind{fileCpt}.txt");
                string newFilePath = Path.Combine(bindPath, $"bind{fileCpt + 1}.txt");

                string iterString = string.Empty;
                for (int j = 0; j < itemsPerFiles; j++)
                {
                    iterString += $"set_title {i + j}$$";
                }

                string content = $"{bindText} \"{iterString}bind_Load_file {newFilePath}\"";

                File.WriteAllText(currentFilePath, content);
                fileCpt++;
            }
        }
    }
}
