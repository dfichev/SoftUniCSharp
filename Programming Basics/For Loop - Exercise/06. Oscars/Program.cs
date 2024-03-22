using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int critics = int.Parse(Console.ReadLine());


            for (int i = 1; i <= critics; i++)
            {
                string criticName = Console.ReadLine();
                double criticPoints = double.Parse(Console.ReadLine());

                points += criticName.Length * criticPoints / 2;

                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:F1}!");
                    break;
                }

            }
            if (points < 1250.5)
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:F1} more!");
        }
    }
}
