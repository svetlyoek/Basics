using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string lenght = n.ToString();
            int number = n % 10;
            for (int i = 1; i <= lenght.Length; i++)
            {
                if (number == 0)
                {
                    Console.Write("ZERO");
                }
                else
                {
                    for (int j = 1; j <= number; j++)
                    {
                        Console.Write((char)(number + 33));
                    }
                }
                Console.WriteLine();
                number = (n / 10) % 10;
                n = n / 10;

            }

        }
    }
        }
        
    
                
        
            
        



           

    
















