using System;

namespace _3._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerSqMeter = double.Parse(Console.ReadLine());
            int wineForSale = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double harvest = grapePerSqMeter * area * 0.4;
            double wineLiters = harvest / 2.5;

            if (wineForSale > wineLiters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineForSale - wineLiters)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {wineLiters} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLiters - wineForSale)} liters left -> {Math.Ceiling((wineLiters - wineForSale) / workers)} liters per person.");

            }

        }
    }
}
