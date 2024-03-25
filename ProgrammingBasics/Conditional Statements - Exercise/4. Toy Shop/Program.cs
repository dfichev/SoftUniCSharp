using System;

namespace _4._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double tripCost = double.Parse(Console.ReadLine());
            int jigsaw = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            
            double income = jigsaw * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            int toyNumber = jigsaw + dolls + bears + minions + trucks;

            if (toyNumber >= 50)
            {
                income -= income * 0.25;
            }

            income = income * 0.9;
                     
            if (income >= tripCost)
            {
                Console.WriteLine($"Yes! {income - tripCost:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(tripCost - income):F2} lv needed.");
            }
           

               

                

        }
    }
}
