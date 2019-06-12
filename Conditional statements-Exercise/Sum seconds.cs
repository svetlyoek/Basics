using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int allTime = sec + sec2 + sec3;
            int minutes = 0;
            if (allTime <= 59)
            {
                minutes = 0;
                allTime = sec + sec2 + sec3;
            }
            if (allTime >= 60 && allTime <= 119)
            {
                minutes++;
                allTime = allTime - 60;
            }
            if (allTime >= 120 && allTime <= 179)
            {
                minutes = minutes + 2;
                allTime = allTime - 120;
            }
            if (allTime < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + allTime);
            }
            else
            {
                Console.WriteLine(minutes + ":" + allTime);
            }
        }
        }
    }

