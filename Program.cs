using System;

namespace TripCali
{
    class Program
    {   
        public  Double MilesCalc(Double dist){
            Console.WriteLine("Enter Distance in miles:");
            String val = Console.ReadLine();
            dist = Convert.ToDouble(val);

            return 0;
        }
        public Double FeetCalc(Double dist){
            Console.WriteLine("Enter Distance in feet: ");
            String val = Console.ReadLine();
            dist = Convert.ToDouble(val);
            return 0;
        }
        public int YardCalc(int dist){
            return 0;
        }
        static void Main(string[] args)
        {
            String x1;
            Console.WriteLine("Enter 1st distances after specifying: (miles = m) (feet = f) ( yards = y)");
            x1 = Console.ReadLine();
            if (x1 == "m"){

            } 

        }
    }
}
