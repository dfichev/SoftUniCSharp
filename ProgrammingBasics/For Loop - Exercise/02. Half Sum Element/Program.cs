using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                
                if (newNumber > maxNumber)
                    maxNumber = newNumber;
                
                sum += newNumber;

            }
            
            sum -= maxNumber;
            
            if (sum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - maxNumber));
            }
        }
    }
}
