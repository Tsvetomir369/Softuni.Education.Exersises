﻿using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal toDollars = pounds * 1.31m;
            Console.WriteLine($"{toDollars:f3}");
        }
    }
}
