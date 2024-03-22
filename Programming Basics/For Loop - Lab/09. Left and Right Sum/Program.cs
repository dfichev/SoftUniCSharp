using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumLeft = 0;

            for (int i = 0; i < num; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sumLeft += newNum;
            }

            int sumRight = 0;
            for (int i = 0; i < num; i++)
            {
                int newNum = int.Parse(Console.ReadLine());
                sumRight += newNum;
            }
            if (sumLeft == sumRight)
                Console.WriteLine(" Yes, sum = " + sumLeft);
            else 
                Console.WriteLine(" No, diff = " + Math.Abs(sumRight - sumLeft));
        }
    }
}
