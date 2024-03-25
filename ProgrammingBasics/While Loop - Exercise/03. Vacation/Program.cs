using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tourCost = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendDays = 0;
            double dailyAmount;
            double sum = 0;
            string action = string.Empty;
            sum += startMoney;

            while (sum < tourCost)
            {
                action = Console.ReadLine();
                dailyAmount = double.Parse(Console.ReadLine());

                daysCount++;

                if (action == "spend")
                {
                    spendDays++;
                    
                    if (spendDays > 4)
                    {
                        break;
                    }                    
                    if (dailyAmount >= sum)
                    {
                        sum = 0;
                    }
                    else
                    {
                        sum -= dailyAmount;
                          if (sum < 0)
                            sum = 0;
                    }                   
                }               
                if (action == "save")
                {
                    sum += dailyAmount;
                    spendDays = 0;
                }
            }
            if (spendDays > 4)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCount);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
} 
