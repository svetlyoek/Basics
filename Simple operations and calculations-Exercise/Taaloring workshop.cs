using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = double.Parse(Console.ReadLine());
            double tablesLenght = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());
            double areaOfRectangleCovers = tables * (tablesLenght + (2 * 0.30)) * (tablesWidth + (2 * 0.30));
            double areaOfCubeCovers = tables * (tablesLenght / 2) * (tablesLenght / 2);

            double sumInDollars = areaOfRectangleCovers * 7 + areaOfCubeCovers * 9;
            double sumInLevas = sumInDollars * 1.85;
            Console.WriteLine($"{sumInDollars:F2} USD ");
            Console.WriteLine($"{sumInLevas:F2} BGN");


        }
    }
}
