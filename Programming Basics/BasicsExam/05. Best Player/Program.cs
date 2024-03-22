using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string player = string.Empty;
            
            int mostGoals = 0;
            string bestPlayer = string.Empty;

            

            while (input != "END")
            {
                player = input;
                int goals = int.Parse(Console.ReadLine());
                

                if(goals > mostGoals)
                {
                    mostGoals = goals;
                    bestPlayer = player;
                }
                if (goals >= 10)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if(mostGoals >= 3)
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            else
                Console.WriteLine($"He has scored {mostGoals} goals.");
        }
    }
}
