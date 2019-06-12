using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            int counter = 1;
            double sum = 0;
            while (counter <= parts)
            {
                double money = double.Parse(Console.ReadLine());
                if (money < 0)
                {



                    Console.WriteLine("Invalid operation!");


                    break;
                }



                if (money > 0)
                {
                    sum += money;
                    Console.WriteLine("Increase: {0:f2}", money);
                    counter++;
                }
            }


            Console.WriteLine("Total: {0:f2}", sum);


        }
    }
        }
    


        
    
    
        
    

