using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroidz
{
    class Asteroid
    {
        // Asteroids variables
        public string Name { get; set; }
        public double Magnitude { get; set; }
        public double DiameterMin { get; set; }
        public double DiameterMax { get; set; }
        public bool Hazardous { get; set; }
        public string NearApproachDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
