using System;

namespace _7._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double expenses = gpu * 250 + cpu * (gpu * 250 * 0.35) + ram * (gpu * 250 * 0.1);

            if (gpu > cpu)
            {
                expenses *= 0.85;
            }
            
            if (budget >= expenses)
            {
                Console.WriteLine($"You have {budget - expenses:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {expenses - budget:F2} leva more!");
            }
             

        }
    }
}
