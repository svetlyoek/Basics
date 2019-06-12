using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double flowerPrice = 0;

            if (flowerType == "Roses")
            {
                if (quantity > 80)
                {
                    flowerPrice = quantity * 5;
                    flowerPrice = flowerPrice - (flowerPrice * 0.1);
                }
                else
                {
                    flowerPrice = quantity * 5;
                }
            }

            else if (flowerType == "Dahlias")
            {
                if (quantity > 90)
                {
                    flowerPrice = quantity * 3.80;
                    flowerPrice = flowerPrice - (flowerPrice * 0.15);
                }
                else
                {
                    flowerPrice = quantity * 3.80;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (quantity > 80)
                {
                    flowerPrice = quantity * 2.80;
                    flowerPrice = flowerPrice - (flowerPrice * 0.15);
                }
                else
                {
                    flowerPrice = quantity * 2.80;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (quantity < 120)
                {
                    flowerPrice = quantity * 3.00;
                    flowerPrice = flowerPrice + (flowerPrice * 0.15);
                }
                else
                {
                    flowerPrice = quantity * 3.00;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (quantity < 80)
                {
                    flowerPrice = quantity * 2.50;
                    flowerPrice = flowerPrice + (flowerPrice * 0.20);
                }
                else
                {
                    flowerPrice = quantity * 2.50;
                }
            }
            if (budget >= flowerPrice)
            {
                double partMoney = Math.Abs(flowerPrice - budget);
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left."
                    , quantity, flowerType, partMoney);
            }

            else
            {
                double partMoney = Math.Abs(budget - flowerPrice);

                Console.WriteLine("Not enough money, you need {0:f2} leva more.", partMoney);
            }
        }
            }
        }
        
    
    
        
    

