﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            // 1 usd = 1.79549 BGN
            double bgn = usd * 1.79549;
            Console.WriteLine(bgn);
        }
    }
}
