using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stepsCount = 0;
            int sum = 0;

            while (input != "Going home")
            {
                stepsCount = int.Parse(input);
                sum += stepsCount;

                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - 10000} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                sum += int.Parse(Console.ReadLine());
                
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sum - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{10000 - sum} more steps to reach goal.");
                }
            }
        }
    }
}
