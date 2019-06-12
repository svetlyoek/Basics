using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (temperature >= 10 && temperature <= 18)
            {
                if (dayTime == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }

                else if ((dayTime == "Afternoon") || (dayTime == "Evening"))
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if ((dayTime == "Morning") || (dayTime == "Evening"))
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }

                else if (dayTime == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }
            }
            else if (temperature >= 25)
            {

                if (dayTime == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }
                else if (dayTime == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }
                else if (dayTime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("It's {0} degrees, get your {1} and {2}.", temperature, outfit, shoes);
                }
            }
            }
        }
        }
    
    
        
    

