using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int books = int.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < books)
            {
                string name = Console.ReadLine();
                if (name != bookName)
                {
                    counter++;
                }


                if (bookName != name && counter == books)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", counter);
                }
                else if (bookName == name)
                {
                    Console.WriteLine("You checked {0} books and found it.", counter);
                    break;

                }
            }
        }
    }
}
        
    


        
    
    
        
    

