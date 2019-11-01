using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaryJason_CE01
{
    public class TeamEventArgs : EventArgs
    {
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Division { get; set; }
    }
}
