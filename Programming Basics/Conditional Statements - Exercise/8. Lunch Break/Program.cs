using System;

namespace _8._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunch = breakTime / 8.0;
            double relax = breakTime / 4.0; 
            double timeLeft = breakTime - (lunch + relax);
            if (timeLeft >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {title} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {title}, you need {Math.Ceiling(episodeLength - timeLeft)} more minutes.");
            }
        }
    }
}
