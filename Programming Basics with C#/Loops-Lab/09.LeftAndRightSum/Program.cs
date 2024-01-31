using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntNums = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= cntNums; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum += leftNum;
            }

            for (int k = 1; k <= cntNums; k++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum += rightNum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                double diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
