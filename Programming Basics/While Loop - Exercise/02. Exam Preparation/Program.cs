using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badCount = int.Parse(Console.ReadLine());
            int poorGrade = 0;
            int tasksCount = 0;
            int score;
            int sumScore = 0;
            string problem = string.Empty;
            

            while (true)
            {
                string lastProblem = problem;

                problem = Console.ReadLine();

                if (problem == "Enough")
                {
                    Console.WriteLine($"Average score: {(double)sumScore / tasksCount:F2}");
                    Console.WriteLine($"Number of problems: {tasksCount}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                
                score = int.Parse(Console.ReadLine());
                tasksCount++;
                sumScore += score;

                if (score <= 4)
                {
                    poorGrade++;

                    if (poorGrade == badCount)
                    {
                        Console.WriteLine($"You need a break, {poorGrade} poor grades.");
                        break;
                    }
                }
            } 
        }
    }
}
