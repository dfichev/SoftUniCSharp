namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arrayMan = input.Split();
            string[] revArr = new string[arrayMan.Length];

            for (int i = 0; i < arrayMan.Length; i++)
            {
                string currentIndex = arrayMan[i];

                revArr[arrayMan.Length -1 - i] = currentIndex;
            }
            foreach (string item in revArr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}