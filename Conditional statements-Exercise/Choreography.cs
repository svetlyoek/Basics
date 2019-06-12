using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiStupki = double.Parse(Console.ReadLine());
            var broiTanciori = double.Parse(Console.ReadLine());
            var broiDni = double.Parse(Console.ReadLine());

            var StupkiNaDen = (broiStupki / broiDni) / broiStupki;
            var Percentages = Math.Ceiling(StupkiNaDen * 100);

            //Console.WriteLine(Math.Ceiling(Percentages) + "%");

            if (Percentages <= 13)
            {
                var stepsDay = Percentages / broiTanciori;
                Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%.", (stepsDay));
            }
            if (Percentages >= 13)
            {
                var stepsDay = Percentages / broiTanciori;
                Console.WriteLine("No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day.", (stepsDay));
            }

        }
    }
    }
        
    

