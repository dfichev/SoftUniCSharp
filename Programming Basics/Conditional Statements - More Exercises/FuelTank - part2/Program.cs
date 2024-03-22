using System;
using System.Globalization;

namespace FuelTank___part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQty = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double fuelCost = 0.0;

            if (card == "No" && fuelQty >= 20 && fuelQty <= 25)
            // Only quantity discount
            {
                if (fuelType == "Gasoline")
                    Console.WriteLine($"{fuelQty * 2.22 * 0.92:F2} lv.");

                else if (fuelType == "Diesel")
                    Console.WriteLine($"{fuelQty * 2.33 * 0.92:F2} lv.");

                else if (fuelType == "Gas")
                    Console.WriteLine($"{fuelQty * 0.93 * 0.92:F2} lv.");
            }

            else if (card == "No" && fuelQty > 25)
            //Only quantity discount
            {
                if (fuelType == "Gasoline")
                    Console.WriteLine($"{fuelQty * 2.22 * 0.90:F2} lv.");

                else if (fuelType == "Diesel")
                    Console.WriteLine($"{fuelQty * 2.33 * 0.90:F2} lv.");

                else if (fuelType == "Gas")
                    Console.WriteLine($"{fuelQty * 0.93 * 0.90:F2} lv.");
            }

            else if (card == "No" && fuelQty < 20)
            //No discount
            {
                if (fuelType == "Gasoline")
                    Console.WriteLine($"{fuelQty * 2.22:F2} lv.");

                else if (fuelType == "Diesel")
                    Console.WriteLine($"{fuelQty * 2.33:F2} lv.");

                else if (fuelType == "Gas")
                    Console.WriteLine($"{fuelQty * 0.93:F2} lv.");

            }

            else if (card == "Yes" && fuelQty < 20)
            // discount under 20 litres of fuel
            {
                if (fuelType == "Gasoline")
                {
                    fuelCost = fuelQty * (2.22 - 0.18);
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }


                else if (fuelType == "Diesel")
                {
                    fuelCost = fuelQty * (2.33 - 0.12);
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
                else if (fuelType == "Gas")
                {
                    fuelCost = fuelQty * (0.93 - 0.08);
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
            }

            else if (card == "Yes" && fuelQty >= 20 && fuelQty <= 25)
            // 8% discount for between 20 and 25 liters of fuel
            {
                if (fuelType == "Gasoline")
                {
                    fuelCost = fuelQty * (2.22 - 0.18) * 0.92;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
                else if (fuelType == "Diesel")
                {
                    fuelCost = fuelQty * (2.33 - 0.12) * 0.92;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
                else if (fuelType == "Gas")
                {
                    fuelCost = fuelQty * (0.93 - 0.08) * 0.92;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
            }
            else if (card == "Yes" && fuelQty > 25)
            // 10% discount for more than 25 liters of fuel
            {
                if (fuelType == "Gasoline")
                {
                    fuelCost = fuelQty * (2.22 - 0.18) * 0.90;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
                else if (fuelType == "Diesel")
                {
                    fuelCost = fuelQty * (2.33 - 0.12) * 0.90;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
                else if (fuelType == "Gas")
                {
                    fuelCost = fuelQty * (0.93 - 0.08) * 0.90;
                    Console.WriteLine($"{fuelCost:F2} lv.");
                }
            }
        }
    }
}
