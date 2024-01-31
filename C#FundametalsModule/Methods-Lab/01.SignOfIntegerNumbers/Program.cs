﻿using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintSign(int.Parse(Console.ReadLine()));
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        static void PrintSign (int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
    }
}
