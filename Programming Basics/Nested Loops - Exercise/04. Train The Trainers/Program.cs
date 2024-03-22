using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryNum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int counter = 0;
            double ratingTotal = 0;
            
            while (input != "Finish")
            {
                
                double ratingSum = 0;

                for (int i = 1; i <= juryNum; i++)
                {
                    double rating = double.Parse(Console.ReadLine());
                    ratingSum += rating;
                }
                Console.WriteLine($"{input} - {ratingSum / juryNum:F2}.");               
                counter++;
                ratingTotal += ratingSum;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {ratingTotal / (counter * juryNum):F2}.");
        }
    }
} 
