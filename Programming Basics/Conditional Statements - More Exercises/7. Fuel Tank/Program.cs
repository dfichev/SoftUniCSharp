using System;

namespace _7._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (quantity < 25 && fuelType == "Diesel")
            {
                Console.WriteLine("Fill your tank with diesel!");
            }
            else if (quantity < 25 && fuelType == "Gasoline")
            {
                Console.WriteLine("Fill your tank with gasoline!");
            }
            else if (quantity < 25 && fuelType == "Gas")
            {
                Console.WriteLine("Fill your tank with gas!");
            }
            else if (quantity >= 25 && fuelType == "Diesel")
            {
                Console.WriteLine("You have enough diesel.");
            }
            else if (quantity >= 25 && fuelType == "Gasoline")
            {
                Console.WriteLine("You have enough gasoline.");
            }
            else if (quantity >= 25 && fuelType == "Gas")
            {
                Console.WriteLine("You have enough gas.");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}
