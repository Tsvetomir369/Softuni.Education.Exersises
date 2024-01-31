using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringOfNumbers = Console.ReadLine()
                .Split('|')
                .ToList();

            stringOfNumbers.Reverse();
            //1 2 3 |4 5 6 | 7 8
            //7 8 | 4 5 6 | 1 2 3 - Reversed

            List<string> result = new List<string>();

            foreach (var currentString in stringOfNumbers)
            {
                string[] numbers = currentString
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
