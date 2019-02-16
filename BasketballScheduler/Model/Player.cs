using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballScheduler.Model
{
    public class Player
    {
        private string tc;
        private int number;
        private string id;
        private string firstName;
        private string lastName;

        public string Tc { get => tc; set => tc = value; }
        public int Number { get => number; set => number = value; }
        public string ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
