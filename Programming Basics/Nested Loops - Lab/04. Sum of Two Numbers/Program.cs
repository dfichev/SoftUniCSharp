using System;
using System.Diagnostics.Tracing;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool stop = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {i + j})");
                        stop = true;
                        break;
                    }
                }
                if (stop)
                    break;
            }
            if (!stop)
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");


        }
    }
}
