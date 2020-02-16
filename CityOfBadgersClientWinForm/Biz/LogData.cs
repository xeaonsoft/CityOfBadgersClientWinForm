using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm
{
    public class LogData
    {
        //public string LogFullPath { get; set; }
        public string GlobalName { get; set; }
        public string ToonName { get; set; }

        public DateTime? LogStartEntry { get; set; }

        public string[] ContentLines { get; set; }

        public string[] DiscoveredEntries { get; set; }

    }
}
