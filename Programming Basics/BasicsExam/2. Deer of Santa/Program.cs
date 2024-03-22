using System;

namespace _2._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodPerDayDeer1 = double.Parse(Console.ReadLine());
            double foodPerDayDeer2 = double.Parse(Console.ReadLine());
            double foodPerDayDeer3 = double.Parse(Console.ReadLine());

            double totalFoodNeeded = (foodPerDayDeer1 + foodPerDayDeer2 + foodPerDayDeer3) * days;

            if (totalFoodNeeded <= foodLeft)
            {
                double foodLeftAfterFeeding = foodLeft - totalFoodNeeded;
                Console.WriteLine($"{Math.Floor(foodLeftAfterFeeding)} kilos of food left.");
            }
            else
            {
                double foodShortage = totalFoodNeeded - foodLeft;
                Console.WriteLine($"{Math.Ceiling(foodShortage)} more kilos of food are needed.");
            }
        }
    }
}