using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            // 1 2 3 3

            for (int i = 0; i < inputArray.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += inputArray[j];
                }

                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    rightSum += inputArray[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
