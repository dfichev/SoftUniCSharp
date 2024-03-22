using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int patientsPerDay = 0;
            int treated = 0;
            int untreated = 0;


            for (int i = 1; i <= period; i++)
            {
                patientsPerDay = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreated > treated)
                {                  
                        doctors++;
                }

                if (patientsPerDay > doctors)
                {
                    untreated += patientsPerDay - doctors;
                    treated += doctors;
                }
                if (patientsPerDay <= doctors)
                {
                    treated += patientsPerDay;
                }
                
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
