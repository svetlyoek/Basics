using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());
            double allTime = 1.0 / (1 / A + 1 / B + 1 / C);
            double newTime = allTime * 0.15;
            double lastTime = allTime + newTime;



            Console.WriteLine($"Cleaning time: {lastTime:f2}");
            if (lastTime < D)
            {
                double time = D - lastTime;
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(time)} hours.");
            }

            else
            {
                double time = lastTime - D;
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(time)} hours.");
            }

        }
    }
    }
        
    

