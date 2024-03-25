using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int newNumber;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                newNumber = int.Parse(input);

                if(newNumber > maxNumber)
                    maxNumber = newNumber;

                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
