using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CityOfBadgersClientTool
{
    public class CohLogProcessing
    {
        const string BadgeDetectionKey1 = "has been selected as new title.";
        const string BadgeDetectionKey2 = "Congratulations! You earned the ";
        public static LogData Process()
        {
            if (MainConfig.Instance.SelectedAccount == null)
            {
                MessageBox.Show("No selected account!");
                return null;
            }
            if (string.IsNullOrEmpty(MainConfig.Instance.SelectedAccount.Name))
            {
                MessageBox.Show("No selected account!");
                return null;
            }





            //string logFileName = CohLogPathManagement.GetLogFileName();
            //string path = Path.Combine(MainConfig.Instance.SelectedAccount.LogFileFolder, logFileName);
            string path = CohLogPathManagement.GetCurrentLogFilePath();
            if (!File.Exists(path))
            {
                MessageBox.Show("Log file is not found!");
                return null;
            }

            if (!ValidateIsHomecoming(path))
            {
                MessageBox.Show("HOMECOMING validation failed!");
                return null;
            }



            LogData data = FetchData(path);
            if (data == null)
            {
                MessageBox.Show("File content is not valid!");
                return null;
            }


            ProcessContent(data);

            return data;
        }
        private static bool ValidateIsHomecoming(string path)
        {
            string parent1 = Directory.GetParent(path).FullName;
            string parent2 = Directory.GetParent(parent1).FullName;
            string gameRootFolder = Directory.GetParent(parent2).FullName;
            string exePath = Path.Combine(gameRootFolder, "homecoming.exe");
            return File.Exists(exePath);
        }
        public static LogData FetchData(string path)
        {



            /*
                Now entering the Rogue Isles, Nikma!
                Welcome to City of Heroes, Cold-Trust!
                Using global chat handle @xeaon
             */
            const string logInRed = "Now entering the Rogue Isles,";
            const string logInBlue = "Welcome to City of Heroes,";
            const string globalEntryStart = "Using global chat handle";

            string[] lines;

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs))
            {
                string content = sr.ReadToEnd();
                lines = content.Split('\r');
            }
            LogData data = new LogData();
            data.ContentLines = lines;
            
            //read lines in reverse
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                string line = lines[i].Trim();
                if (line.Length > 20)
                {
                    string date = line.Substring(0, 20).Trim();
                    line = line.Substring(20, line.Length - 20);

                    if (line.Trim().StartsWith(globalEntryStart))
                    {
                        string name = line.Replace(globalEntryStart, string.Empty);
                        data.GlobalName = name.Substring(0, name.Length).Trim().TrimStart('@');
                    }
                    else if (line.Trim().StartsWith(logInRed) || line.Trim().StartsWith(logInBlue))
                    {
                        string name = line.Replace(logInRed, string.Empty).Replace(logInBlue, string.Empty);
                        data.ToonName = name.Substring(0, name.Length - 1).Trim();
                        data.LogStartEntry = DateTime.Parse(date);
                        
                     
                    }

                    if (!string.IsNullOrEmpty(data.GlobalName) && !string.IsNullOrEmpty(data.ToonName))
                        return data;
                }
            }

            return null;
        }

        private static void ProcessContent(LogData data)
        {


            List<string> discoveredList = new List<string>();

            string[] lines = data.ContentLines;


            var badgesEntries = lines.Where(a => a.EndsWith(BadgeDetectionKey1) || a.Contains(BadgeDetectionKey2));

            foreach (string badgeEntry in badgesEntries)
            {
                //-- cut first 20
                string date = badgeEntry.Substring(0, 20);
                DateTime lineDate = DateTime.Parse(date);
                if (lineDate > data.LogStartEntry)
                {
                    string line = badgeEntry.Substring(20, badgeEntry.Length - 20);
                    if (line.EndsWith(BadgeDetectionKey1))
                    {
                        line = line.Replace(BadgeDetectionKey1, string.Empty).Trim();
                        discoveredList.Add(line);
                    }
                    if (line.Contains(BadgeDetectionKey2))
                    {
                        line = line.Replace(BadgeDetectionKey2, string.Empty);
                        line = line.Replace("badge.", string.Empty);
                        line = line.Trim();
                        discoveredList.Add(line);
                    }
                }
            }


            data.DiscoveredEntries = discoveredList.ToArray();

        }
    }
}
