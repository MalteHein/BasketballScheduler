using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScheduler.JSONParser
{
    public class JSONObjectParser
    {
        //public List<Player> players { get; set; }

        public JSONObjectParser(string JSONString)
        {
            JObject jObject = JObject.Parse(JSONString);
            JToken jUser = jObject["roster"];
            foreach (JToken item in jUser.Children())
            {
                //Player 
            }
        }
    }
}
