using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum1 = 0;
            bool areEqual = false;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else
                {
                    sum1 += firstArr[i];
                    areEqual = true;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum1}");
            }
        }
    }
}
