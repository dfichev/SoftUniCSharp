﻿using System;

namespace Nested_Loops___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 23; h++)
            {
                for (int m = 0; m < 59; m++)
                {
                    Console.WriteLine($"{h:D2}:{m:d2}");
                }
            }
        }
    }
}
