using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    counter1++;
                }
                if (num % 3 == 0)
                {
                    counter2++;
                }
                if (num % 4 == 0)
                {
                    counter3++;
                }
            }
            p1 = (counter1 / n) * 100;
            p2 = (counter2 / n) * 100;
            p3 = (counter3 / n) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }

    }
    }
    

    
















