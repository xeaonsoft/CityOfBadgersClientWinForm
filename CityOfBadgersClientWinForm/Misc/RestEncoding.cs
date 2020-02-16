using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm.Misc
{
    internal class RestEncoding
    {
        public static Encoding Iso88591Instance = Encoding.GetEncoding("iso-8859-1"); 
        public static Encoding UTF8Instance = Encoding.GetEncoding("utf-8");
    }
}
