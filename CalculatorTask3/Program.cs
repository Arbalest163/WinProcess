﻿using System;

namespace CalculatorTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"{arg}");
            }
        }
    }
}