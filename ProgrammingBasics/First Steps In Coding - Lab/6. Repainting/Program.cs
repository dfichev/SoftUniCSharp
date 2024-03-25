using System;

namespace _6._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
              //  Предпазен найлон - 1.50 лв. за кв. метър
              //	Боя - 14.50 лв.за литър
              //	Разредител за боя - 5.00 лв.за литър

            int nylonQty = int.Parse(Console.ReadLine());
            int paintQty = int.Parse(Console.ReadLine());
            int thinnerQty = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());
            double nylonPrice = (nylonQty + 2) * 1.50;
            double paintPrice = paintQty * 1.1 * 14.50;
            double thinnerPrice = thinnerQty * 5;
            double sumMaterials = nylonPrice + paintPrice + thinnerPrice + 0.4;
            double workHoursCost = (sumMaterials * 0.3) * workHours;
            Console.WriteLine(sumMaterials + workHoursCost);
        }
    }
}
