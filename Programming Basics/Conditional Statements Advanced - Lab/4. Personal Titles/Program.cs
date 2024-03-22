using System;

namespace _4._Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (sex == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (sex == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (sex == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else if (sex == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
