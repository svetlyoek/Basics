using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int floors = int.Parse(Console.ReadLine());
            int roomForOneFloor = int.Parse(Console.ReadLine());
            for (int n = floors; n >= 1; n--)
            {
                for (int n2 = 0; n2 < roomForOneFloor; n2++)
                {



                    if (n == floors)
                    {
                        Console.Write($"L{n}{n2} ");


                    }



                    else if (n % 2 == 0)
                    {
                        Console.Write($"O{n}{n2} ");



                    }


                    else
                    {
                        Console.Write($"A{n}{n2} ");

                    }
                }

                Console.WriteLine();




            }
        }
            }
        }



           

    
















