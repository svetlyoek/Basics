using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());


            for (int i = 1; i <= count; i++)
            {
                string product = Console.ReadLine();
                bool eggs = false;
                bool flour = false;
                bool sugar = false;

                while (true)
                {
                    if (product == "eggs")
                    {
                        eggs = true;
                    }
                    else if (product == "flour")
                    {
                        flour = true;
                    }
                    else if (product == "sugar")
                    {
                        sugar = true;
                    }
                    else if (product == "Bake!")
                    {
                        if (eggs && sugar && flour == true)
                        {
                            Console.WriteLine("Baking batch number {0}...", i);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    product = Console.ReadLine();

                }
            }
                }
        }
            }
        



           

    
















