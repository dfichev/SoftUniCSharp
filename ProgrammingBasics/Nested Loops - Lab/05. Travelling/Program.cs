﻿using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            while (input != "End")
            {               
                double budget = double.Parse(Console.ReadLine());
                double sum = 0;
               
                while (sum < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                }
                Console.WriteLine($"Going to {input}!");
                
                input = Console.ReadLine();
            }

        }
    }
}
