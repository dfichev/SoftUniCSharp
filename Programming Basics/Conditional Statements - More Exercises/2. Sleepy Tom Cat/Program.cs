using System;

namespace _2._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int workDays = 365 - restDays;
            int yearPlay = restDays * 127 + workDays * 63;
            int limitPlay = 30000;
            int diffTime = Math.Abs(yearPlay - limitPlay);
            
            if (yearPlay > limitPlay)
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffTime / 60} hours and {diffTime % 60:D2} minutes more for play");
            }
            else
            {

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffTime / 60} hours and {diffTime % 60:D2} minutes less for play");
            }
        }
    }
}
