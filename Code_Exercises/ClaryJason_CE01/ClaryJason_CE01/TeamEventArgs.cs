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
    public class TeamEventArgs : EventArgs
    {
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Division { get; set; }
    }
}
