using System;

namespace _8._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());
            double sneackers = annualTax * 0.6;
            double outfit = sneackers * 0.8;
            double ball = outfit * 0.25;
            double accessories = ball * 0.2;
            Console.WriteLine(annualTax + sneackers + outfit + ball + accessories);

        }
    }
}
