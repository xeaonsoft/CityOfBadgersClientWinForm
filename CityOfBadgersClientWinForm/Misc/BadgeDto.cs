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
        public string CharacterName { get; set; }
        public string[] BadgeKeys { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.ClientToken) || string.IsNullOrEmpty(this.GlobalName) || string.IsNullOrEmpty(this.CharacterName))
                return false;
            if (BadgeKeys == null || BadgeKeys.Length == 0)
                return false;
            return true;
        }
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
