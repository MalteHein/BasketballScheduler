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
            JToken jRoster = jObject["roster"];
            // Init Teams 
            foreach (JToken item in jRoster.Children())
            { 
                // Unterscheidung via Teamname (Attribut)
                //Player p = new Player();
                //p.
                // Füge Spielerliste Teams hinzu
            }
        }
    }
}
