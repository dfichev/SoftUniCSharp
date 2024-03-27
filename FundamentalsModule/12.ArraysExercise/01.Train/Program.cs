namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int total = 0;
            int[] people = new int[wagons];

            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                total += people[i];
            }
            for (int i = 0; i < wagons; i++)
            {
                Console.Write($"{people[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}