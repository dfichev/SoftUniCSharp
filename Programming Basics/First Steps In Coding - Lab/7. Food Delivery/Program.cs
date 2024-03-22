using System;

namespace _7._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пилешко меню –  10.35 лв.
	        //Меню с риба – 12.40 лв.
	        //Вегетарианско меню  – 8.15 лв
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegMenus = int.Parse(Console.ReadLine());
            double totalChicken = chickenMenus * 10.35;
            double totalFish = fishMenus * 12.40;
            double totalVegetarian = vegMenus * 8.15;
            double ttlCost = (totalChicken + totalFish + totalVegetarian) * 1.20; //20% dessert
            ttlCost += 2.50;
            Console.WriteLine(ttlCost);

        }
    }
}
