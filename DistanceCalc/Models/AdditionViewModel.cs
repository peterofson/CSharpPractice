using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DistanceCalc.Models
{

    public class AdditionViewModel {

        public double A { get; set; }

        public double B { get; set; }

        public double Miles { get; set; }
        public double Yards { get; set; }
        public double Feet { get; set;  }

        public double Calculates
        {
            get
            {
                return Miles;
            }
            set { Miles = value; }
        }

    }

}


