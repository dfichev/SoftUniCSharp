namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            //OPERATIONS

            for (int i = 0; i < rotations; i++)
            {
                
                string firstElement = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];

                }
                input[input.Length - 1] = firstElement;
            }
            //OUTPUT
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
