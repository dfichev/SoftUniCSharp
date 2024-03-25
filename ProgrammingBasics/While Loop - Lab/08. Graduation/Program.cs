using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();           
            int badCount = 0;
            int gradeCount = 1;
            double sum = 0;

            while (gradeCount <= 12)
            {
                double evaluation = double.Parse(Console.ReadLine());

                if (evaluation < 4)
                {
                    badCount++;

                    if (badCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeCount} grade");
                        break;
                    }
                    continue;
                }
                sum += evaluation;
                gradeCount++;
            }
            if (badCount < 2)
            Console.WriteLine($"{name} graduated. Average grade: {(double)sum / 12:F2}");


        }
    }
}
