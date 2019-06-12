using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    int num = int.Parse(command);


                    if (num > maxNum)
                    {
                        maxNum = num;
                    }
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }
            }


            Console.WriteLine("Max number: {0}", maxNum);
            Console.WriteLine("Min number: {0}", minNum);


        }
    }
        }
    


        
    
    
        
    

