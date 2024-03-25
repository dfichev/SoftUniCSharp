using System;

namespace _1._Cat_Diet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatPercentage = int.Parse(Console.ReadLine());
            int proteinPercentage = int.Parse(Console.ReadLine());
            int carbsPercentage = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int waterContent = int.Parse(Console.ReadLine());

            double fatWeight = totalCalories * fatPercentage / 100.0 / 9.0;
            double proteinWeight = totalCalories * proteinPercentage / 100.0 / 4.0;
            double carbsWeight = totalCalories * carbsPercentage / 100.0 / 4.0;

            double foodWeight = fatWeight + proteinWeight + carbsWeight;
            double caloriesPerGram = totalCalories / foodWeight;

            double caloriesPerGramWithoutWater = caloriesPerGram - caloriesPerGram * waterContent / 100.0;
            Console.WriteLine($"{caloriesPerGramWithoutWater:F4}");
        }
    }
}