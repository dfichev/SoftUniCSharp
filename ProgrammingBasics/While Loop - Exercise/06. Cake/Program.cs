using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cake = length * width;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieces = int.Parse(input);

                cake -= pieces;

                if (cake <= 0)
                {
                    break;
                }
                
                input = Console.ReadLine();
            }
            if (cake <= 0)
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            else
                Console.WriteLine($"{Math.Abs(cake)} pieces are left.");
        }
    }
}
