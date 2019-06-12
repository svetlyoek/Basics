using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double avGrade = 0;
            double sumGrades = 0;
            double totalSum = 0;
            int counter = 0;
            while (command != "Finish")
            {
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                    counter++;
                    totalSum += grade;
                    if (i == n)
                    {
                        avGrade = sumGrades / i;
                        Console.WriteLine($"{command} - {avGrade:f2}.");
                        sumGrades = 0;
                    }
                }

                command = Console.ReadLine();
            }
            double finalGrade = totalSum / counter;
            Console.WriteLine($"Student's final assessment is {finalGrade:f2}.");
        }

        }
    }
        
        
    
                
        
            
        



           

    
















