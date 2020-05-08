using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientTool
{
    public class LiveLog
    {
        public delegate void InfoEvent(string line);

        public InfoEvent OnInfoEvent { get; private set; }
        public static void Init(InfoEvent ev)
        {
            LiveLog.Instance = new LiveLog();
            LiveLog.Instance.OnInfoEvent = ev;
        }

        public static LiveLog Instance { get; private set; }

        public void Log(string line)
        {
            OnInfoEvent(line);
        }
    }
}
