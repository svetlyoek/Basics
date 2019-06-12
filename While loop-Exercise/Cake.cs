using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int pieces = length * width;
            int piecesLeft = 0;
            int piecesSum = 0;
            string command = "";
            while (true)
            {
                command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }


                int piecesTaken = int.Parse(command);
                piecesSum += piecesTaken;

                if (piecesSum > pieces)
                {
                    piecesLeft = piecesSum - pieces;
                    Console.WriteLine("No more cake left! You need {0} pieces more.", piecesLeft);
                    break;
                }

            }


            if (command == "STOP" && pieces > piecesSum)
            {
                double leftPieces = pieces - piecesSum;
                Console.WriteLine("{0} pieces are left.", leftPieces);
            }

        }
    }
}
        
    

        
    


        
    
    
        
    

