using System;

namespace _5._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackets = int.Parse(Console.ReadLine());
            int markerPackets = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double penSum = penPackets * 5.8;
            double markerSum = markerPackets * 7.2;
            double detergentSum = detergent * 1.2;
            double price = penSum + markerSum + detergentSum;
            double discountedPrice = price - price * (discount * 0.01);
            Console.WriteLine(discountedPrice);

        }
    }
}
