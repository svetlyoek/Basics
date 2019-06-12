using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            if (minutes >= 60)
            {
                hour = hour + 1;
                minutes = minutes - 60;

                if (hour >= 24)
                    hour = hour - 24;

            }
            Console.WriteLine("{0}:{01:00}", hour, minutes);


        }
    }
    }
        
    

