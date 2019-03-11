﻿using System;
using System.Collections.Generic;

namespace TripCali
{
    class Program
    {   
        public static void  FeetCalcToMiles(Double dist, Double miles){
            Double fnl_miles = 0;
            if (dist < 5280){
                fnl_miles = 0;
            }
            else { fnl_miles = dist/5280; } 
           
            Double final_yards = (dist%5280)/3;
            Double feetz = Convert.ToInt16(final_yards%3);
            Double tst = miles + Math.Truncate(fnl_miles);

            Console.WriteLine("Miles: " + tst);
            Console.WriteLine("Yards: " + Math.Truncate(final_yards));
            Console.WriteLine("Feet : " + feetz);
            
        }
        public static void  FeetCalcToYards(Double dist){
            dist = dist/3;
            int feetz = Convert.ToInt16(dist%3);
            Console.WriteLine("Yards: " + Math.Truncate(dist));
            Console.WriteLine("Feet : " + feetz);
        }
        public static Double YardCalc(Double dist){
            if (dist >= 1760){
                // Converting yards to miles 
                dist = dist/1760;
            }
            else dist = 0;
            return Math.Round(dist,1);
        }

        static void Main(string[] args)
        {
            // Create an empty list to store values 
            List<double> Input_First_Dist = new List<double>();
            List<double> Input_Scd_Dist = new List<double>();
            Double final_miles = 0;
            Double seconddist;
            String val;
            Double firstdist;



            // Prompt user for miles yards or feet 
            Console.WriteLine("Enter (miles = m) (feet = f) or ( yards = y)");
            String x1 = Console.ReadLine();
            
            
            if (x1 == "m"){
                Console.WriteLine("Enter 1st Distance in Miles:");
                 val = Console.ReadLine();
                 firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            } 
            else if (x1 =="f"){
                Console.WriteLine("Enter 1st Distance in Feet:");
                 val = Console.ReadLine();
                 firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            }
            else if (x1 =="y"){
                Console.WriteLine("Enter 1st Distance in Yards:");
                 val = Console.ReadLine();
                 firstdist = Convert.ToDouble(val);
                Input_First_Dist.Add(firstdist);
            }
            
            // Getting Second Distance 
            Console.WriteLine(" Now enter (miles = m) (feet = f) or ( yards = y)");
            String x2 = Console.ReadLine(); 
            if (x2 == "m"){
                Console.WriteLine("Enter 2nd Distance in Miles:");
                 val = Console.ReadLine();
                 seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            } 
            else if (x2 =="f"){
                Console.WriteLine("Enter 2nd Distance in Feet:");
                 val = Console.ReadLine();
                 seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            }
            else if (x2 =="y"){
                Console.WriteLine("Enter 2nd Distance in Yards:");
                 val = Console.ReadLine();
                 seconddist = Convert.ToDouble(val);
                Input_Scd_Dist.Add(seconddist);
            }
            
                // Determing which function to use - if any 
                // Maybe come up with a loop for the follwing 
                //////////////////////////////////////////////
            if ((x1 == "m") && (x2 =="m")){
                final_miles = Input_First_Dist[0] + Input_Scd_Dist[0];
                Console.WriteLine("Total miles = " + final_miles);
            }
            else if (x1=="m" && (x2=="f")){      
                FeetCalcToMiles(Input_Scd_Dist[0], Input_First_Dist[0]);            
            }
            



        }
    }
}
