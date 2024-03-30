namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int counter = 1;
            int maxCounter = 0;
            int num = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                        counter++;

                    if (sequence[i] == sequence[j])
                    {

                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                            num = sequence[i];
                        }

                    }
                    else
                    {
                        counter = 1;
                        break;
                    }
                }
                counter = 1;
            }
            for (int k = 0; k < maxCounter; k++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}