using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int bookCount = 0;

            while (true)
            {
                string newBook = Console.ReadLine();
                
                
                        
                if(newBook == favBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }
                if (newBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }
                bookCount++;

            }
        }
    }
}
