using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScheduler.Model
{
    public class Team
    {
        private string contraction;
        private string id;
        private string tc;
        private string fullName;
        private string nat;
        private List<Player> players = new List<Player>();

        public string Contraction
        {
            get => contraction;
            set => contraction = value;
        }
        public string ID
        {
            get => id;
            set => id = value;
        }
        public string Nat
        {
            get => nat;
            set => nat = value;
        }
        public string FullName
        {
            get => fullName;
            set => fullName = value;
        }
        public string Tc
        {
            get => tc;
            set => tc = value;
        }

        public List<Player> Players
        {
            get => players;
            set => players = value;
        }
    }
}
