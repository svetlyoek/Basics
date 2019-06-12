using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double holidaysHome = double.Parse(Console.ReadLine());
            double holidaysSofia = 48 - holidaysHome;
            double realHolidaysSofia = holidaysSofia * 3.0 / 4;
            double realholidaysHome = holidaysHome;
            double otherHolidays = holidays * 2.0 / 3;
            double allPlays = realHolidaysSofia + realholidaysHome + otherHolidays;
            if (yearType == "leap")
            {
                double finalPlays = allPlays + (allPlays * 0.15);
                {
                    Console.WriteLine(Math.Truncate(finalPlays));
                }
            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Truncate(allPlays));
            }
        }
        }
    }


        
    
    
        
    

