using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            
            string input = Console.ReadLine();
                               
            while (input != "NoMoreMoney")
            {              
                double newNumber = double.Parse(input);
                
                if (newNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");                    
                    break;
                }

                Console.WriteLine($"Increase: {newNumber:F2}");

                sum += newNumber; 
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");

        }
    }
}
