using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * height * length;
            int freeVolume = 0;
            int boxesSum = 0;

            while (freeVolume <= volume)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }
                else
                {
                    int boxesCount = int.Parse(command);
                    boxesSum += boxesCount * 1;
                }
                freeVolume = volume - boxesSum;
                if (freeVolume <= 0)
                {
                    break;
                }

            }
            if (freeVolume <= 0)
            {
                int neededVolume = Math.Abs(boxesSum - volume);
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", neededVolume);
            }
            else
            {
                int leftVolume = (volume - boxesSum);
                Console.WriteLine("{0} Cubic meters left.", leftVolume);
            }

        }
    }
}
        
    


        
    
    
        
    

