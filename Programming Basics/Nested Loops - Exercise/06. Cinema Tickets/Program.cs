using System;
using System.Runtime.CompilerServices;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int student = 0;
            int standard = 0;
            int kid = 0;
            int totalTickets = 0;
            int movieCount = 0;
            
            string ticketType = string.Empty;
            
            while (input != "Finish")
            {
                movieCount++;
                int seats = int.Parse(Console.ReadLine());
                int movieTickets = 0;
                for (int i = 1; i <= seats; i++)
                {                    
                    ticketType = Console.ReadLine();
                    
                    if (ticketType == "End")
                        break;
                    else if (ticketType == "student")
                    {
                        movieTickets++;
                        student++;
                        totalTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        movieTickets++;
                        standard++;
                        totalTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        movieTickets++;
                        kid++;
                        totalTickets++;
                    }

                }
                Console.WriteLine($"{input} - {(double)movieTickets / seats * 100:F2}% full.");
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(double)student / totalTickets * 100:F2}% student tickets.");
            Console.WriteLine($"{(double)standard / totalTickets * 100:F2}% standard tickets.");
            Console.WriteLine($"{(double)kid / totalTickets * 100:F2}% kids tickets.");
        }
    }
}
