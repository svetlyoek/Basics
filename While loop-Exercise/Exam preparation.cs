using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowGrades = int.Parse(Console.ReadLine());
            int allproblemCount = 0;
            int lowGradeCount = 0;
            double averageGrade = 0;
            double sumGrades = 0;
            string lastProblemName = "";
            string problem = Console.ReadLine();
            while (problem != "Enough")
            {








                double grade = double.Parse(Console.ReadLine());
                lastProblemName = problem;
                allproblemCount++;
                sumGrades += grade;

                if (grade <= 4)
                {
                    lowGradeCount++;
                }
                if (lowGradeCount == lowGrades)
                {
                    break;
                }
                problem = Console.ReadLine();
            }




            if (problem == "Enough")
            {
                averageGrade = sumGrades / allproblemCount;
                Console.WriteLine("Average score: {0:f2}", averageGrade);
                Console.WriteLine("Number of problems: {0}", allproblemCount);
                Console.WriteLine("Last problem: {0}", lastProblemName);
            }
            else if (problem != "Enough" && lowGradeCount == lowGrades)
            {
                Console.WriteLine("You need a break, {0} poor grades.", lowGradeCount);

            }

        }
    }
        }
    

        
    


        
    
    
        
    

