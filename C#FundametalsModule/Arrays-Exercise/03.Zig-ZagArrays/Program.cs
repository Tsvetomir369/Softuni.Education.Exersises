using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            //4
            //1 5
            //9 10
            //31 81
            //41 20
            int[] firstArray = new int[input];
            int[] secondArray = new int[input];

            for (int i = 0; i < input; i++)
            {
                int[] currentNums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = currentNums[0];
                    secondArray[i] = currentNums[1];
                }
                else
                {
                    firstArray[i] = currentNums[1];
                    secondArray[i] = currentNums[0];
                }
            }

            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));

        }
    }
}
