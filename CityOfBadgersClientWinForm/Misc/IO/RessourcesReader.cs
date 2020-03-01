using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientTool
{
    public class RessourcesReader
    {
        public static string TextFileRessourceToString(byte[] bytesFromRessource)
        {
            using (MemoryStream ms = new MemoryStream(bytesFromRessource))
            using (var reader = new StreamReader(ms))
                return reader.ReadToEnd();
        }
    }
}
