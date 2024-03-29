namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];
            int j = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                int[] pairs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    first[k] = pairs[0];
                    k++;
                    second[j] = pairs[1];
                    j++;
                }
                else
                {
                    first[k] = pairs[1];
                    k++;
                    second[j] = pairs[0];
                    j++;
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}