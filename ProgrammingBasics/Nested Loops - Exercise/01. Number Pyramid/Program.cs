using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;

            for (int rows = 0; rows < num; rows++)
            {
                for (int cols = 0; cols <= rows; cols++)
                {
                    if (current > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                        break;
                Console.WriteLine();
            }
        }
    }
}
