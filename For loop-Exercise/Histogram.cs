using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    counter2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    counter3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    counter4++;
                }
                else if (num >= 800)
                {
                    counter5++;
                }
            }
            p1 = (counter1 / n) * 100;
            p2 = (counter2 / n) * 100;
            p3 = (counter3 / n) * 100;
            p4 = (counter4 / n) * 100;
            p5 = (counter5 / n) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }

    }
    }
    

    
















