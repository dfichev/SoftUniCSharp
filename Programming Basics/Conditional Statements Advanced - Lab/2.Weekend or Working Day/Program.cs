﻿using System;

namespace _2.Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                Console.WriteLine("Weekend");
                    break ;
                default: 
                Console.WriteLine("Error");
                    break;
            }
        }
    }
}
