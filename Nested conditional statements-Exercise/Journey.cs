using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double money = 0.0;
            string destination = "";
            string type = "";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    money = budget * 0.30;
                    type = "Camp";
                    destination = "Bulgaria";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", type, money);
                }

                else if (season == "winter")
                {
                    money = budget * 0.70;
                    type = "Hotel";
                    destination = "Bulgaria";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", type, money);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    money = budget * 0.40;
                    type = "Camp";
                    destination = "Balkans";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", type, money);
                }

                else if (season == "winter")
                {
                    money = budget * 0.80;
                    type = "Hotel";
                    destination = "Balkans";
                    Console.WriteLine("Somewhere in {0}", destination);
                    Console.WriteLine("{0} - {1:f2}", type, money);
                }
            }
            else if (budget > 1000)
            {
                money = budget * 0.90;
                type = "Hotel";
                destination = "Europe";
                Console.WriteLine("Somewhere in {0}", destination);
                Console.WriteLine("{0} - {1:f2}", type, money);

            }
        }
    }
}
        
    
    
        
    

