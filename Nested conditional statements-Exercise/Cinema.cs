using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string projects = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double colums = double.Parse(Console.ReadLine());
            double premiere = 12.00 * rows * colums;
            double normal = 7.50 * rows * colums;
            double discount = 5 * rows * colums;
            if (projects == "Premiere")
            {
                double price = premiere;
                {
                    Console.WriteLine("{0:f2}", price);
                }
            }
            else if (projects == "Normal")
            {
                double price = normal;
                {
                    Console.WriteLine("{0:f2}", price);
                }
            }
            else if (projects == "Discount")
            {
                double price = discount;
                {
                    Console.WriteLine("{0:f2}", price);
                }
            }
            }
        }
        }
    
    
        
    

