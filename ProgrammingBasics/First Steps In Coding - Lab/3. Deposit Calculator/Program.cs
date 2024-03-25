using System;

namespace _3._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumInitial = double.Parse(Console.ReadLine());
            int durationMonths = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double interestRate1 = interestRate / 100;
            // сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
           double sumFinal = sumInitial + durationMonths * ((sumInitial * interestRate1) / 12);
            Console.WriteLine(sumFinal);
            

        }
    }
}
