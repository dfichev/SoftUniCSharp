using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoes = int.Parse(Console.ReadLine());

            int busWeight = 0;
            int truckWeight = 0;
            int trainWeight = 0;
            int totalWeight = 0;

            for (int i = 0; i < cargoes; i++)
            {
                int shipment = int.Parse(Console.ReadLine());

                if (shipment <= 3)
                    busWeight += shipment;                  
                else if (shipment <= 11)
                    truckWeight += shipment;
                else
                    trainWeight += shipment;

                totalWeight += shipment;
            }
            double averagePricePerTon = (double)(busWeight * 200 + truckWeight * 175 + trainWeight * 120) / totalWeight;
            Console.WriteLine($"{averagePricePerTon:F2}");
            Console.WriteLine($"{1.0 * busWeight / totalWeight * 100:F2}%");
            Console.WriteLine($"{1.0 * truckWeight / totalWeight * 100:F2}%");
            Console.WriteLine($"{1.0 * trainWeight / totalWeight * 100:F2}%");
        }
    }
}
