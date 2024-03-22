using System;

namespace _9._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            //banana, apple, kiwi, cherry, lemon и grapes
            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                //tomato, cucumber, pepper и carrot
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break ;
                default: Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
