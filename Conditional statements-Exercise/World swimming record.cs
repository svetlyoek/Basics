using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double metres = double.Parse(Console.ReadLine());
            double secondsForMeter = double.Parse(Console.ReadLine());
            double timeForSwim = metres * secondsForMeter;
            double realTime = Math.Floor(metres / 15) * 12.5;
            double realTime2 = realTime + timeForSwim;
            if (recordInSeconds <= realTime2)
            {

                Console.WriteLine($"No, he failed! He was {realTime2 - recordInSeconds:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {realTime2:f2} seconds.");
            }



        }
    }
    }
        
    

