using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = int.MinValue;
            int sum = 0;
            int diff = 0;
            int secondSum = 0;
            for (int i = 1; i <= n; i++)
            {
                secondSum = sum;
                sum = 0;
                int num = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum += num + num2;
                if (i != 1)
                {

                    diff = Math.Abs(sum - secondSum);

                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
            }

            if (sum == secondSum || n == 1)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }

        }
    }
    }

    
















