using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityOfBadgersClientTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string lines = string.Empty;
            //for (int j = 0; j < 50; j++)
            //{
            //    int x = j * 50;
            //    string s = "settitle 0$$";//input dummy one
            //    for (int i = 1; i <= 50; i++)
            //    {
            //        s += $"settitle {x+i}$$";
            //    }
            //    s = s.Trim().TrimEnd('$');
            //    s += "\r\n";
            //    lines += s;
            //}
            //lines = lines.Trim();

            //System.IO.File.WriteAllText("c:\\temp\\coh settitles 2500-v3.txt", lines);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
