using System;

namespace _3._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = hours * 60 + minutes + 15;
            hours = time / 60;
            minutes = time % 60;
            bool newDay = hours == 24;
            if (newDay)
            {
                Console.WriteLine($"0:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}
