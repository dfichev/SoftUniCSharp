namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(arguments[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(arguments[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(arguments[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
