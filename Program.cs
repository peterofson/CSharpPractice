using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
         public static void  FeetCalcToMiles(Double dist, Double miles){
            Double fnl_miles;
            Double final_yards; 
            Double feetz; 
            Double tst ;

            if (dist < 5280){
                fnl_miles = 0;
            }
            else { fnl_miles = dist/5280; }
             
            tst = miles + Math.Truncate(fnl_miles);
            final_yards = Math.Truncate((dist%5280)/3);
            feetz = Convert.ToInt16((dist%5280)%3);

            Console.WriteLine("Miles: " + tst);
            Console.WriteLine("Yards: " + Math.Truncate(final_yards));
            Console.WriteLine("Feet : " + feetz);
        }

        public static void YardsCalctoMiles(Double dist, Double miles){
            Double fnl_miles;
            Double final_yards; 
            Double tst;

            if (dist < 1760 ){
                fnl_miles = 0;
            }
            else { fnl_miles = dist/1760;}
            tst = miles + Math.Truncate(fnl_miles);
            final_yards = Math.Truncate(dist%1760);

            Console.WriteLine("Miles: " + tst);
            Console.WriteLine("Yards: " + final_yards);
        }

        public static void FeetPlusFeet(Double first_feet, Double scd_feet){
            Double miles;
            Double fnl_feet;
            Double fnl_yrds;
            Double feet_sum = first_feet + scd_feet;
            if (feet_sum < 5280) { miles = 0; }
            else { miles = Math.Truncate(feet_sum/5280); }
                
            fnl_yrds = (feet_sum%5280)/3;
            fnl_feet = (feet_sum%5280)%3; 
            
             Console.WriteLine("Miles: " + miles);
            Console.WriteLine("Yards: " + Math.Truncate(fnl_yrds));
            Console.WriteLine("Feet : " + fnl_feet);
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
                
                /// Miles is first choice 
            if ((x1 == "m") && (x2 =="m")){
                final_miles = Input_First_Dist[0] + Input_Scd_Dist[0];
                Console.WriteLine("Total miles = " + final_miles);
            }
            else if (x1=="m" && (x2=="f")){      
                FeetCalcToMiles(Input_Scd_Dist[0], Input_First_Dist[0]);            
            }
            else if (x1=="m" && x2=="y"){
                YardsCalctoMiles(Input_Scd_Dist[0], Input_First_Dist[0]);
            }
            /// Feet is first choice 
            else if (x1=="f" && x2 == "m"){
                FeetCalcToMiles(Input_First_Dist[0],Input_Scd_Dist[0]);
            }
            else if (x1=="f" && x2=="f"){
                FeetPlusFeet(Input_First_Dist[0],Input_Scd_Dist[0]);
            }
            else if (x1=="f" && x2=="y"){

            }
            /// Yards is first choice 
            else if (x1=="y" && x2=="m"){
    
            }
            else if (x1=="y" && x2=="f"){

            }
            else if (x1=="y" && x2=="y"){

            }
        }
    }
}
