using System;

namespace _5._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                    price = qty * 0.5;
                else if (product == "water")
                    price = qty * 0.8;
                else if (product == "beer")
                    price = qty * 1.20;
                else if (product == "sweets")
                    price = qty * 1.45;
                else if (product == "peanuts")
                    price = qty * 1.6;
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                    price = qty * 0.4;
                else if (product == "water")
                    price = qty * 0.7;
                else if (product == "beer")
                    price = qty * 1.15;
                else if (product == "sweets")
                    price = qty * 1.30;
                else if (product == "peanuts")
                    price = qty * 1.5;
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                    price = qty * 0.45;
                else if (product == "water")
                    price = qty * 0.7;
                else if (product == "beer")
                    price = qty * 1.10;
                else if (product == "sweets")
                    price = qty * 1.35;
                else if (product == "peanuts")
                    price = qty * 1.55;
            }
            Console.WriteLine(price);
        }
    }
}
