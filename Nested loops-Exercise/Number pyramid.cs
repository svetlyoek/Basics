using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (num > n)
                    {
                        break;
                    }
                    Console.Write("{0} ", num);
                    num++;
                }
            }

        }
    }
        }
        
    
                
        
            
        



           

    
















