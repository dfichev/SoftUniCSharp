using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numMax = int.MinValue;
            int numMin = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int numNew = int.Parse(Console.ReadLine());

                if (numNew > numMax)
                {
                    numMax = numNew;
                }
                if (numMin > numNew)
                {
                    numMin = numNew;
                }
            }
            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
        }
    }
}
