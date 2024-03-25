using System;

namespace _6._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolesNum = int.Parse(Console.ReadLine());
            int zumbulesNum = int.Parse(Console.ReadLine());
            int rosesNum = int.Parse(Console.ReadLine());
            int cactusNum = int.Parse(Console.ReadLine());
            double gift = double.Parse(Console.ReadLine());

            double incomeAftTax = (magnolesNum * 3.25 + zumbulesNum * 4.00 + rosesNum * 3.50 + cactusNum * 8.00) * 0.95;

            if (gift > incomeAftTax)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(gift - incomeAftTax)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(incomeAftTax - gift)} leva.");
            }
        }
    }
}
