using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOfBadgersClientWinForm
{
    public class RestBasicDto
    {
        public string Data { get; set; }



        public static BadgeDto FromJSON(string content)
        {
            return JsonConvert.DeserializeObject<BadgeDto>(content);
        }
        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static string Prep(string input)
        {
            
            string compressed = GZipCompression.Compress(input);
            string b64 = Base64.Base64Encode(compressed);

            return (new RestBasicDto { Data = b64 }).ToJSON();

        }
    }
}
