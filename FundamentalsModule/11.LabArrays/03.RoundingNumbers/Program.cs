namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine($"{number[j]} => {(int)Math.Round(number[j], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}