using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studioPrice = 0;

            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nights;
                apartmentPrice = 65 * nights;
                if (nights > 7 && nights <= 14)
                {
                    studioPrice = nights * 50 * 0.95;

                    apartmentPrice = 65 * nights;





                }
                else if (nights > 14)
                {
                    studioPrice = nights * 50 * 0.70;

                    apartmentPrice = nights * 65 * 0.90;


                }
            }
            else if (month == "June" || month == "September")
            {


                if (nights > 14)
                {
                    studioPrice = nights * 75.20 * 0.80;

                    apartmentPrice = nights * 68.70 * 0.90;


                }
                else if (nights <= 14)
                {
                    studioPrice = 75.20 * nights;
                    apartmentPrice = 68.70 * nights;

                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;
                if (nights > 14)
                {
                    apartmentPrice = nights * 77 * 0.90;


                }
                else if (nights <= 14)
                {
                    studioPrice = 76 * nights;
                    apartmentPrice = 77 * nights;

                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
        }
    }

        
    
    
        
    

