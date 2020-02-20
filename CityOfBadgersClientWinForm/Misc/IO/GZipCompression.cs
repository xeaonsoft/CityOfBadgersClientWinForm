using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm
{
    public class GZipCompression
    {
        public static string Compress(string input)
        {
            using (var outStream = new MemoryStream())
            {
                using (var stream = new GZipStream(outStream, CompressionMode.Compress))
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(input)))
                    ms.CopyTo(stream);

                byte[] compressedBytes = outStream.ToArray();
                return Convert.ToBase64String(compressedBytes);
            }
        }


        public static string Decompress(string input)
        {
            byte[] inputBytes = Convert.FromBase64String(input);
            using (var ms = new MemoryStream(inputBytes))
            using (var gzStream = new GZipStream(ms, CompressionMode.Decompress))
            using (var msOut = new MemoryStream())
            {
                gzStream.CopyTo(msOut);
                string output = Encoding.UTF8.GetString(msOut.ToArray());
                return output;
            }
        }
    }
}
