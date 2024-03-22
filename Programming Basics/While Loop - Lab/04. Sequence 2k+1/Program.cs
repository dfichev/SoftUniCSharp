using System;

namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int input = 1;

            while (input <= n)
            {
                Console.WriteLine(input);

                
                input = 2 * input + 1;
                
            }
        }
    }
}
