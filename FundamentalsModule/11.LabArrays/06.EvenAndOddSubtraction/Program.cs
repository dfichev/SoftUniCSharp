namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int odd = 0;
            int even = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i];

                if (current % 2 == 0)
                {
                    even += current;
                }
                else
                {
                    odd += current;
                }
            }
            Console.WriteLine(even - odd);
        }
    }
}