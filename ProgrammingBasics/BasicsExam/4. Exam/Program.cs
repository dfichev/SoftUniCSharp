using System;

namespace _4._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int counter56 = 0;
            int counter45 = 0;
            int counter34 = 0;
            int counter23 = 0;
            
            double gradeSum = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                gradeSum += grade;

                if (grade >= 2 && grade < 3)
                {
                    counter23++;                   
                }
                else if (grade >= 3 && grade < 4)
                {
                    counter34++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    counter45++;
                }
                else if (grade >= 5)
                {
                    counter56++;
                }
                
            }
            Console.WriteLine($"Top students: {(double)counter56 / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)counter45 / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)counter34 / students * 100:F2}%");
            Console.WriteLine($"Fail: {(double)counter23 / students * 100:F2}%");
            Console.WriteLine($"Average: {(double)gradeSum / students:F2}");
        }
    }
}
