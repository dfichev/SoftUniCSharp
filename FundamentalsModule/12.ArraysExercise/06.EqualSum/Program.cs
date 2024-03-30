using System.Diagnostics.CodeAnalysis;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            bool no = default;

            for (int i = 0; i < sequence.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                
                for (int j = sequence.Length - 1; j > i; j--)
                {
                    rightSum += sequence[j];

                }
                for (int k = 0; k < i; k++)
                {
                    leftSum += sequence[k];

                }
                if (i == 0)
                {
                    leftSum = 0;
                }
                else if (i == sequence.Length - 1)
                {
                    rightSum = 0;
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine($"{i}");
                    no = true;
                }
            }
            if (no == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}