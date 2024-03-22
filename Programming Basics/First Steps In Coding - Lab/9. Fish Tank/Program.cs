using System;

namespace _9._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double ballastPercentage = double.Parse(Console.ReadLine());
            double waterQty = (length * width * height) * 0.001;
            waterQty -= ballastPercentage * 0.01 * waterQty;
            Console.WriteLine(waterQty);
        }
    }
}
