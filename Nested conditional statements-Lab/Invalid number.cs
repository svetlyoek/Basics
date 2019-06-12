using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var range = (num >= 100 && num <= 200 || num == 0);
            if (!range)
            {
                Console.WriteLine("invalid");
            }
        }
        }
    }
    
        
    

