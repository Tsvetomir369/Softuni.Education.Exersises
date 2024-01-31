using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                int[] indexesElements = input.Split(' ').Select(int.Parse)
                    .ToArray();


            }
        }
    }
}
