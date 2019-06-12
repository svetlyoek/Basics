using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toyCounter = 0;
            double money = 0;
            double brother = 0;
            double finalMoney = 0;
            double savedMoney = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 != 0)
                {
                    toyCounter++;

                }
                else if (i % 2 == 0)
                {
                    money += 10;
                    savedMoney += money;
                    brother++;
                }
            }

            finalMoney = savedMoney + (toyCounter * toyPrice) - brother;
            if (finalMoney < washingMachinePrice)
            {
                double neededMoney = washingMachinePrice - finalMoney;
                Console.WriteLine("No! {0:f2}", neededMoney);
            }
            else if (finalMoney >= washingMachinePrice)
            {
                double moneyLeft = finalMoney - washingMachinePrice;
                Console.WriteLine("Yes! {0:f2}", moneyLeft);
            }
        }
    }
    }
    
















