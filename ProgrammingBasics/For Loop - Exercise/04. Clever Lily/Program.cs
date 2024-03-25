using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if(birthday % 2 == 0)
                {
                    money += birthday * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                } 

            }
            if(money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money - washingMachine:F2}");
            }
            else if (washingMachine > money)
            {
                Console.WriteLine($"No! {washingMachine - money:F2}");
            }

        }
    }
}
