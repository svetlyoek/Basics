using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWhiskey = double.Parse(Console.ReadLine());
            double quantityOfBeer = double.Parse(Console.ReadLine());
            double quantityOfWine = double.Parse(Console.ReadLine());
            double quantityOfRakia = double.Parse(Console.ReadLine());
            double quantityOfWhiskey = double.Parse(Console.ReadLine());
            double rakiaPrice = priceOfWhiskey / 2;
            double winePrice = rakiaPrice - (0.4 * rakiaPrice);
            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);
            double sumForRakia = rakiaPrice * quantityOfRakia;
            double sumForWine = winePrice * quantityOfWine;
            double sumOfBeer = beerPrice * quantityOfBeer;
            double sumOfWhiskey = priceOfWhiskey * quantityOfWhiskey;
            double allSum = sumForRakia + sumForWine + sumOfBeer + sumOfWhiskey;
            Console.WriteLine("{0:F2}", allSum);

        }
    }
}
