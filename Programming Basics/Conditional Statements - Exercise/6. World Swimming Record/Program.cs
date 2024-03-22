using System;

namespace _6._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double resistance = Math.Floor(distance / 15) * 12.5;
            double newTime = distance * timePerMeter + resistance;

            if (newTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {newTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {newTime - record:F2} seconds slower.");
            }


        }
    }
}
