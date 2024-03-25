using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int persons = int.Parse(Console.ReadLine());

            double price = 0.0;
            double transport = 0.0;

            switch (category)
            {
                case "VIP":
                    price = 499.99;
                    break;
                case "Normal":
                    price = 249.99;
                    break ;
            }
            if (persons >= 1 && persons <= 4)
                transport = budget * 0.75;
            else if (persons >= 5 && persons <= 9)
                transport = budget * 0.60;
            else if (persons >= 10 && persons <= 24)
                transport = budget * 0.50;
            else if (persons >= 25 && persons <= 49)
                transport = budget * 0.40;
            else if (persons >= 50)
                transport = budget * 0.25;
            if (budget >= (transport + persons * price))
                Console.WriteLine($"Yes! You have {budget - (transport + persons * price):F2} leva left.");
            else if (budget < (transport + persons * price))
                Console.WriteLine($"Not enough money! You need {(transport + persons * price) - budget:F2} leva.");


        }
            
    }
}
