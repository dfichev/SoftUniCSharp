namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count / 2; i++)
            {
                int first = list[i];
                int last = list[list.Count - i - 1];
                newList.Add(first + last);
            }
            if (list.Count % 2 == 1)
            {
                newList.Add(list[list.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
