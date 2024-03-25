using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double gradesSum = 0;
            int poorGrades = 0;
            int avrgGrades = 0;
            int goodGrades = 0;
            int topGrades = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 3)
                    poorGrades++;
                else if (grade >= 3 && grade < 4)
                    avrgGrades++;
                else if (grade >= 4 && grade < 5)
                    goodGrades++;
                else if (grade >= 5)
                    topGrades++;

                gradesSum += grade;
            }
            Console.WriteLine($"Top students: {1.0 * topGrades / students * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {1.0 * goodGrades / students * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {1.0 * avrgGrades / students * 100:F2}%");
            Console.WriteLine($"Fail: {1.0 * poorGrades / students * 100:F2}%");
            Console.WriteLine($"Average: {gradesSum /students:F2}");



        }
    }
}
