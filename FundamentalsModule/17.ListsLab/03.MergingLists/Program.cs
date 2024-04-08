namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> combined = new List<int>();

            int iterations = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < iterations; i++)
            {
                if (i < list1.Count)
                {
                    combined.Add(list1[i]);
                }
                if (i < list2.Count)
                {
                    combined.Add(list2[i]);

                }
            }
            Console.WriteLine(string.Join(" ", combined));
        }
    }
}