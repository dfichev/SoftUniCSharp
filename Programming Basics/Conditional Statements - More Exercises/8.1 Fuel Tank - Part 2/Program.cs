using System;

namespace _8._1_Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQty = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            double cost = 0.0;

            if (card == "Yes")
            {
                gasoline -= 0.18;
                diesel -= 0.12;
                gas -= 0.08;
            }
            if (fuelType == "Gasoline")
            {
                cost = fuelQty * gasoline;
            }
            else if (fuelType == "Diesel")
            {
                cost = fuelQty * diesel;
            }
            else if (fuelType == "Gas")
            { 
                cost = fuelQty * gas;
            }
            if (fuelQty >= 20 && fuelQty <= 25)
            {
                cost -= 0.08 * cost;
            }
            else if (fuelQty > 25)
            {
                cost -= 0.10 * cost;
            }
            Console.WriteLine($"{cost:F2} lv.");
        }
    }
}
