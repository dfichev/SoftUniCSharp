using System;
using System.Diagnostics;

namespace _3._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageWeight = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            double addOn = 0;
            double pricePerKm = 0;
            
            if(packageWeight < 1)
            {
                pricePerKm = 3;
                if (service == "express")
                    addOn = pricePerKm * 0.8 * packageWeight * distance;
            }
            else if (packageWeight >= 1 && packageWeight < 10)
            {
                pricePerKm = 5;
                if (service == "express")
                    addOn = pricePerKm * 0.4 * packageWeight * distance;
            }
            else if (packageWeight >= 10 && packageWeight < 40)
            {
                pricePerKm = 10;
                if (service == "express")
                    addOn = pricePerKm * 0.05 * packageWeight * distance;
            }
            else if (packageWeight >= 40 && packageWeight < 90)
            {
                pricePerKm = 15;
                if (service == "express")
                    addOn = pricePerKm * 0.02 * packageWeight * distance;
            }
            else if (packageWeight >= 90 && packageWeight < 150)
            {
                pricePerKm = 20;
                if (service == "express")
                    addOn = pricePerKm * 0.01 * packageWeight * distance;
            }
            if (service == "express")
            {
                Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:F3} kg. would cost {(pricePerKm * distance + addOn) / 100:F2} lv.");
            }
            else
                Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:F3} kg. would cost {pricePerKm * distance / 100:F2} lv.");

        }
    }
}
