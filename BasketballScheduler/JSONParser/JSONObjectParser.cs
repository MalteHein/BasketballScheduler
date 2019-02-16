using BasketballScheduler.Model;
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
        private List<Team> teams = new List<Team>();

        public JSONObjectParser(string JSONString)
        {
            ReadJSON(JSONString);
        }

        public void ReadJSON(string JSONString)
        {
            JObject jObject = JObject.Parse(JSONString);
            JToken jTeamroster = jObject["teamroster"];
            JToken jRoster = jObject["roster"];

            // Init teams 
            if (jTeamroster != null)
            {
                foreach (JToken item in jTeamroster.Children())
                {
                    Team team = new Team();
                    team.Tc = item["TC"].ToString();
                    team.ID = item["TID"].ToString();
                    team.Contraction = item["Team"].ToString();
                    team.FullName = item["TeamName"].ToString();
                    team.Nat = item["NAT"].ToString();
                    teams.Add(team);
                }
            }

            // Init players 
            if (jRoster != null)
            {
                foreach (JToken item in jRoster.Children())
                {
                    Player player = new Player();
                    player.Tc = item["TC"].ToString();
                    player.Number = Convert.ToInt32(item["Nr"].ToString());
                    player.ID = item["ID"].ToString();
                    player.FirstName = item["FirstName"].ToString();
                    player.LastName = item["Name"].ToString();

                    foreach (Team team in Teams)
                    {
                        if (team.Tc == player.Tc)
                        {
                            team.Players.Add(player);
                        }
                    }
                }
            }
        }

        public List<Team> Teams
        {
            get => teams;
            set => teams = value;
        }
    }
}
