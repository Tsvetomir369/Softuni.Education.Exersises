using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            int sumWithoutMaxNum = sum - maxNum;
            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNum}");
            }
            else
            {
                int diff = Math.Abs(sumWithoutMaxNum - maxNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
