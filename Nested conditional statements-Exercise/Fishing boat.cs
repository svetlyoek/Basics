using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double rentPrice = 0;
            if (season == "Spring")
            {
                rentPrice = 3000.0;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rentPrice = 4200.0;
            }
            else if (season == "Winter")
            {
                rentPrice = 2600.0;
            }

            if (people <= 6)
            {
                rentPrice = rentPrice - (rentPrice * 0.10);
            }
            else if (people >= 7 && people <= 11)
            {
                rentPrice = rentPrice - (rentPrice * 0.15);
            }
            else if (people > 12)
            {
                rentPrice = rentPrice - (rentPrice * 0.25);
            }

            if (season == "Summer" || season == "Winter" || season == "Spring")
            {
                if (people % 2 == 0)
                {
                    rentPrice = rentPrice - (rentPrice * 0.05);
                }
            }

            if (budget >= rentPrice)
            {
                double finalSum = (budget - rentPrice);
                Console.WriteLine("Yes! You have {0:f2} leva left.", finalSum);
            }

            else
            {
                double finalSum = Math.Abs(budget - rentPrice);
                Console.WriteLine("Not enough money! You need {0:f2} leva.", finalSum);
            }

        }
    }
        }
        
    
    
        
    

