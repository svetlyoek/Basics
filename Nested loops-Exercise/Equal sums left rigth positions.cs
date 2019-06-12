using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = num1; i <= num2; i++)
            {
                int lastDigit = i % 10;
                int prelastDigit = (i / 10) % 10;
                int middleDigit = (i / 100) % 10;
                int secondDigit = (i / 1000) % 10;
                int firstDigit = (i / 10000) % 10;
                leftSum = secondDigit + firstDigit;
                rightSum = lastDigit + prelastDigit;

                if (rightSum != leftSum && rightSum < leftSum)
                {

                    rightSum += middleDigit;
                }
                else if (leftSum < rightSum && leftSum != rightSum)
                {
                    leftSum += middleDigit;
                }


                if (rightSum == leftSum)
                {
                    Console.Write("{0} ", i);
                }
            }

        }
    }
        }
        
    
                
        
            
        



           

    
















