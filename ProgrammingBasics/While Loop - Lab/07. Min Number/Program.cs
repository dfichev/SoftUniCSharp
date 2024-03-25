using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int newNumber = int.Parse(input);

                if (newNumber < minNumber)
                    minNumber = newNumber;

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
