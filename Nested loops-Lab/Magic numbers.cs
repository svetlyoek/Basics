﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int e = 1; e <= 9; e++)
                            {
                                for (int f = 1; f <= 9; f++)
                                {

                                    if (a * b * c * d * e * f == n)
                                    {

                                        Console.Write("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);

                                    }

                                }

                            }
                        }
                    }
                }

            }

        }
        }
    }
                
        
            
        



           

    
















