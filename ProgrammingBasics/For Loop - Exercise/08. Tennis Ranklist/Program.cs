using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int wins = 0;
            int startingPoints = points;
            
            for (int i = 1; i <= n; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W": points += 2000;
                        wins++;
                        break;
                    case "F": points += 1200;
                        break;
                    case "SF": points += 720;
                        break;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor((double)(points - startingPoints) / n):F0}");
            Console.WriteLine($"{(double)wins / n * 100:F2}%");
        }
    }
}
