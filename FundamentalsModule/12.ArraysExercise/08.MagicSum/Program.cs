namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int uniqueNum = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (sequence[i] + sequence[j] == uniqueNum)
                    {
                        a = sequence[i];
                        b = sequence[j];
                        Console.WriteLine($"{a} {b}");
                    }
                }
            }

        }
    }
}
