using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaryJason_CE02
{
    class FullSailClass
    {
        // holds data pulled from database
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public int Term { get; set; }
        public double CreditHours { get; set; }
        public string Track { get; set; }

        public FullSailClass()
        {
     
        }

        public override string ToString()
        {
            return CourseName;
        }
    }
}
