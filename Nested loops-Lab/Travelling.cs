using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string destination = Console.ReadLine();
            double allMoney = 0;

            while (destination != "End")
            {
                double minBudjet = double.Parse(Console.ReadLine());
                if (minBudjet == 0) { Console.WriteLine($"Going to {destination}!"); }
                else
                {
                    while (true)
                    {
                        double safeMoney = double.Parse(Console.ReadLine());

                        allMoney += safeMoney;
                        if (allMoney >= minBudjet)
                        {
                            Console.WriteLine($"Going to {destination}!");
                            break;
                        }
                    }
                    allMoney = 0;
                    destination = Console.ReadLine();
                }



            }
        }
            }
        }



           

    
















