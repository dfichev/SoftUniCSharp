using System;

namespace _5._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            double totalFoodNeeded = days * (dogFoodPerDay + catFoodPerDay + turtleFoodPerDay * 0.001);

            if (totalFoodNeeded > foodLeft)
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - foodLeft)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(foodLeft - totalFoodNeeded)} kilos of food left.");
            }

        }
    }
}
