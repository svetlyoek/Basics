using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 1;
            double sum = 0;
            double lowGradeCounter = 0;
            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;
                }
                else if (grade < 4.00)
                {
                    lowGradeCounter++;

                }


                if (lowGradeCounter > 1)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade", name, counter);
                    return;
                }

            }
            double averageGrade = sum / 12;
            Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, averageGrade);
        }

    }
    }
        
    


        
    
    
        
    

