using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Jason W. Clary
  Project & Portfolio 3 - 1911
  Code Exercise 01
 */

namespace ClaryJason_CE01
{
    class FootballTeam
    {
        // team variables
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Division { get; set; }


        public FootballTeam()
        {

        }

        // only used for initial data
        public FootballTeam(string name, string city, string div)
        {
            TeamName = name;
            City = city;
            Division = div;
        }

        // string format for division lists
        public override string ToString()
        {
            return $"{City} {TeamName}";
        }
    }
}
