using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            while (true)
            {
                int newNumber = int.Parse(Console.ReadLine());

                sum += newNumber;

                if (sum >= initialNumber)
                {
                    Console.WriteLine(sum);
                    break;
                }

                
            }
        }
    }
}
