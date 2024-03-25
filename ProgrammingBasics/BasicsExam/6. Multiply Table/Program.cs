using System;

namespace _6._Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;
            int middleDigit = (num / 10) % 10;
            int firstDigit = (num / 100) % 10;

            for (int i = 1; i <= lastDigit; i++)
            {
                for (int k = 1; k <= middleDigit; k++)
                {
                    for (int l = 1; l <= firstDigit; l++)
                    {
                        Console.WriteLine($"{i} * {k} * {l} = {i * k * l};");
                    }
                }
            }
        }
    }
}
