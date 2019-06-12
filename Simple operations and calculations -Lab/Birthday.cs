using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp219
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            double percents = double.Parse(Console.ReadLine());
            double volumeInCubics = lenght * height * wide;
            double volumeInLiters = volumeInCubics * 0.001;
            double otherPercents = percents * 0.01;
            double realLiters = volumeInLiters * (1 - otherPercents);
            Console.WriteLine($"{realLiters:F3}");

        }
    }
    }

            


        
    























