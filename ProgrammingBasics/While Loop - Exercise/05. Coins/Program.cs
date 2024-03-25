using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine()) * 100;

            int coins = 0;

            while (input > 0)
            {
                if (input >= 200)
                {
                    input -= 200;
                    coins++;
                }
                else if (input >= 100)
                {
                    input -= 100;
                    coins++;
                }
                else if (input >= 50)
                {
                    input -= 50;
                    coins++;
                }
                else if (input >= 20)
                {
                    input -= 20;
                    coins++;
                }
                else if (input >= 10)
                {
                    input -= 10;
                    coins++;
                }
                else if (input >= 5)
                {
                    input -= 5;
                    coins++;
                }
                else if (input >= 2)
                {
                    input -= 2;
                    coins++;
                }
                else if (input >= 1)
                {
                    input -= 1;
                    coins++;
                }
                else
                    input = 0;


            }
            Console.WriteLine(coins);
        }
    }
}
