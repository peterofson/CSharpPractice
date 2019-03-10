using System;
using System.Collections.Generic;

namespace TripCali
{
    class Program
    {   
        public Double FeetCalc(Double dist){
            if (dist >= 5280){
                // Converting feet to miles 
                dist = dist/5280;
            }
            else if (dist >= 3){
                // Converting feet to yards
                dist = dist/3;
            }
            return dist;
        }
        public int YardCalc(int dist){
            if (dist >= 1760){
                // Converting yards to miles 
                dist = dist/1760;
            }
            return dist;
        }

        static void Main(string[] args)
        {
            // Create an empty list to store values 
            List<double> Input_First_Dist = new List<double>();
            List<double> Input_Scd_Dist = new List<double>();
            
            // Prompt user for miles yards or feet 
            Console.WriteLine("Enter (miles = m) (feet = f) or ( yards = y)");
            String x1 = Console.ReadLine();
            
            if (x1 == "m"){
                Console.WriteLine("Enter 1st Distance in Miles:");
                String val = Console.ReadLine();
                Double firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            } 
            else if (x1 =="f"){
                Console.WriteLine("Enter 1st Distance in Feet:");
                String val = Console.ReadLine();
                Double firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            }
            else if (x1 =="y"){
                Console.WriteLine("Enter 1st Distance in Yards:");
                String val = Console.ReadLine();
                Double firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            }
            
            // Getting Second Distance 
            Console.WriteLine("Enter (miles = m) (feet = f) or ( yards = y)");
            String x2 = Console.ReadLine(); 
            if (x2 == "m"){
                Console.WriteLine("Enter 2nd Distance in Miles:");
                String val = Console.ReadLine();
                Double seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            } 
            else if (x2 =="f"){
                Console.WriteLine("Enter 2nd Distance in Feet:");
                String val = Console.ReadLine();
                Double seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            }
            else if (x2 =="y"){
                Console.WriteLine("Enter 2nd Distance in Yards:");
                String val = Console.ReadLine();
                Double seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            }
            
                // Determing which function to use - if any 
            if ((x1 == "m") && (x2 =="m")){
                Double final = Input_First_Dist[0] + Input_Scd_Dist[0];
            }



        }
    }
}
