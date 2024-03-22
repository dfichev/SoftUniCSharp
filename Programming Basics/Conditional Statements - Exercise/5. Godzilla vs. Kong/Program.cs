using System;

namespace _5._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfitCost = double.Parse(Console.ReadLine());
            
            double clothing = outfitCost * extras;
            double decor = budget * 0.1;
            
            if (extras > 150)
            {
                clothing *= 0.9;
            }
            double expenses = clothing + decor;
            if (expenses > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expenses - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - expenses:F2} leva left.");
            }
        }
    }
}
