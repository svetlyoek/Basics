using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            double areaOfTheHall = (hallLenght * 100) * (hallWidth * 100);
            double areaOfTheWardrobe = (wardrobeSide * wardrobeSide) * 10000;
            double areaOfBench = areaOfTheHall / 10;
            double realAreaOfTheHall = areaOfTheHall - areaOfTheWardrobe - areaOfBench;
            double sumOfDancers = realAreaOfTheHall / 7040;
            Console.WriteLine(Math.Truncate(sumOfDancers));


        }
    }
}
