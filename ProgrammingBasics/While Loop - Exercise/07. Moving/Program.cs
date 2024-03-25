using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wigth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            
            int volume = wigth * length * height;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);

                volume -= boxes;

                if (volume <= 0)
                    break;

                input = Console.ReadLine();
            }
            if (volume <= 0)
                Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
            else
                Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
