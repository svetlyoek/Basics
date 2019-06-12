using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());

            double BGN = USD * 1.79549;
            Console.WriteLine(Math.Round(BGN, 2));

        }
    }
}
