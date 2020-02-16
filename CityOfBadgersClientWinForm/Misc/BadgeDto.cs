using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CityOfBadgersClientWinForm
{
    public class BadgeDto
    {
        public string ClientToken { get; set; }
        public string GlobalName { get; set; }
        public string BadgeKey { get; set; }

        public static BadgeDto FromJSON(string content)
        {
            return JsonConvert.DeserializeObject<BadgeDto>(content);
        }
        public string ToJSON()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
