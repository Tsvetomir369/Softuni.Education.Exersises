using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2 1 1 2 3 3 2 2 2 1
            //2 2 2

            int length = 1;
            int startIndex = 0;

            int maxLength = 0;
            int bestStartIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    startIndex = i;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    bestStartIndex = startIndex;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + maxLength; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
