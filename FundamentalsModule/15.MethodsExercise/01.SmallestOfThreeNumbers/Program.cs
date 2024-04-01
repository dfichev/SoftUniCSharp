
namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            if (first > second) 
            { 
                char swap = first;
                first = second;
                second = swap;
            }

            PrintCharRange(first, second);
        }

        static void PrintCharRange(char first, char second)
        {
            int from = (int)first;
            int to = (int)second;

            for (int i = from + 1; i < to; i++)
            {
                Console.Write($"{(char)i} ");
            }
            
        }

    }
}
