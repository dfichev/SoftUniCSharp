﻿using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int newNum = int.Parse(Console.ReadLine());

                if (newNum < 200)
                    p1++;
                else if (newNum < 400)
                    p2++;
                else if (newNum < 600)
                    p3++;
                else if (newNum < 800)
                    p4++;
                else
                    p5++;
            }
            Console.WriteLine($"{p1 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p2 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p3 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p4 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p5 * 1.0 / n * 100:F2}%");
        }
    }
}
