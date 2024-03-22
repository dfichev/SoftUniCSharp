using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());

            int age = 18;
            int yearsPassed = yearToLive - 1799;

            for (int i = 0; i < yearsPassed; i++)
            {
                if (i % 2 == 0)
                {
                    inheritance -= 12000;
                }
                else
                {
                    inheritance -= 12000 + 50 * age;
                }
                age++;
            }
            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:F2} dollars left.");
            }
            else if (inheritance < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):F2} dollars to survive.");
            }
        }
    }
}
