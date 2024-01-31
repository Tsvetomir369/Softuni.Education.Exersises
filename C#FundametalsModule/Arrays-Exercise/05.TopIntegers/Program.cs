using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //27 19 42 2 13 45 48

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
        }
    }
}
