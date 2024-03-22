using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            // 2.50	     1.20	      0.85     	1.45	2.70	5.50	    3.85
            double cost = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.5:F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.2:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.85:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.45:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 2.7:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.5:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 3.85:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
                //banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                //2.70        1.25    0.90    1.60      3.00     5.60        4.20

            {
                if (fruit == "banana")
                {
                    Console.WriteLine($"{quantity * 2.7:F2}");
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine($"{quantity * 1.25:F2}");
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine($"{quantity * 0.9:F2}");
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine($"{quantity * 1.6:F2}");
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine($"{quantity * 3:F2}");
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine($"{quantity * 5.6:F2}");
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine($"{quantity * 4.2:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
                Console.WriteLine("error");
        }
    }
}
