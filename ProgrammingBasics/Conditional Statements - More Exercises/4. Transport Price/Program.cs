using System;

namespace _4._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            if (partOfTheDay == "day" && range < 20)
            {
                Console.WriteLine($"{0.70 + range * 0.79:F2}");
            }
            else if (partOfTheDay == "night" && range < 20)
            {
                Console.WriteLine("{0:F2}", 0.70 + range * 0.90);
            }
            else if (range < 100)
            {
                Console.WriteLine("{0:F2}", range * 0.09);
            }
            else if (range >= 100)
            {
                Console.WriteLine("{0:F2}", range * 0.06);
            }
        }
    }
}
