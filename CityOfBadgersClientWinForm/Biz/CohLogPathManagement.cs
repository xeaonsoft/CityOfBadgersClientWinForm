using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityOfBadgersClientTool
{
    internal class CohLogPathManagement
    {
        public static void FetchLogFilePath()
        {
            //FolderBrowserDialog dialogue = new FolderBrowserDialog();

            //if (!string.IsNullOrEmpty(MainConfig.Instance.LogFileFolder))
            //{
            //    if (Directory.Exists(MainConfig.Instance.LogFileFolder))
            //        dialogue.SelectedPath = MainConfig.Instance.LogFileFolder;
            //}

            //DialogResult dr = dialogue.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    MainConfig.Instance.LogFileFolder = dialogue.SelectedPath;
            //    MainConfig.Instance.Save();
            //    Process();
            //}

            string defaultPath = null;
            if (!string.IsNullOrEmpty(MainConfig.Instance.LogFileFolder))
            {
                if (Directory.Exists(MainConfig.Instance.LogFileFolder))
                    defaultPath = MainConfig.Instance.LogFileFolder;
            }

            var dialogue = new Ionic.Utils.FolderBrowserDialogEx
            {
                Description = "Select a folder:",
                ShowNewFolderButton = false,
                ShowEditBox = true,
                SelectedPath = defaultPath,
                ShowFullPathInEditBox = true,

            };

            dialogue.RootFolder = System.Environment.SpecialFolder.MyComputer;

            var result = dialogue.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainConfig.Instance.LogFileFolder = dialogue.SelectedPath;
                MainConfig.Instance.Save();
                Process();
            }
        }

        internal static string GetLogFileName()
        {
            return $"chatlog {DateTime.Today:yyyy-MM-dd}.txt"; 
        }
        public static void Process()
        {
            MainConfig.Instance.SelectedAccount = ProcessPath();
            MainConfig.Instance.Save();
        }
        private static AccountData ProcessPath()
        {
            string path = MainConfig.Instance.LogFileFolder;
            List<AccountData> accountList = new List<AccountData>();
            string fileSearchPath = GetLogFileName();
            string[] files = Directory.GetFiles(path, fileSearchPath, SearchOption.AllDirectories);
            foreach (string file in files)
            {
                string folder = Path.GetDirectoryName(file);
                var parent = Directory.GetParent(folder);
                if (parent != null)
                {
                    var account = new AccountData {
                        Name = parent.Name,
                        LogFileFolder = folder
                    };

                    if (!accountList.Any(a=> a.Name == account.Name))
                        accountList.Add(account);
                }
            }





            if (!accountList.Any())
                return null;

            //if (accountNames.Count == 1)
            //    return accountNames.First();



            using (FormSelectAccount frm = new FormSelectAccount())
            {
                frm.AccountList = accountList.ToArray();
                frm.ShowDialog();

                return frm.Selection;
            }
        }
    }
}
