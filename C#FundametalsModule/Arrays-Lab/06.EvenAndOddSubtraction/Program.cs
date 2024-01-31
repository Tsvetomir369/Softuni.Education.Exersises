using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //int sumEven = 0;
            //int sumOdd = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currentNum = nums[i];
            //    if (currentNum % 2 == 0)
            //    {
            //        sumEven += currentNum;
            //    }
            //    else
            //    {
            //        sumOdd += currentNum;
            //    }
            //}

            //Console.WriteLine(sumEven - sumOdd);
            int[] numsArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < numsArr.Length; i++)
            {
                if (numsArr[i] % 2 == 0)
                {
                    sumEven += numsArr[i];
                }
                else
                {
                    sumOdd += numsArr[i];
                }
            }

            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
