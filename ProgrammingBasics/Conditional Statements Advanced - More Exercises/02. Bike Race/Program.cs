using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();

            double donation = 0.0;

            switch (raceType)
            {
                case "trail":
                    donation = juniors * 5.50 + seniors * 7;
                    break;
                case "cross-country":
                    donation = juniors * 8 + seniors * 9.50;
                    break;
                case "downhill":
                    donation = juniors * 12.25 + seniors * 13.75;
                    break;
                case "road":
                    donation = juniors * 20 + seniors * 21.50;
                    break;
            }
            if (juniors + seniors >= 50 && raceType == "cross-country")
                donation *= 0.75;
            donation *= 0.95;
            Console.WriteLine($"{donation:F2}");

        }
    }
}
