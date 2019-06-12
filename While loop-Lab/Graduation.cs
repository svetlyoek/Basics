using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sum = 0;
            double counter = 1;
            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;


                }
            }
            double averageGrade = sum / 12;
            Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, averageGrade);


        }
    }
        }
    


        
    
    
        
    

