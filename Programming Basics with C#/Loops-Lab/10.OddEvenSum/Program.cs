using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntNums = int.Parse(Console.ReadLine());
            int evenNumsSum = 0;
            int oddNumsSum = 0;

            for (int i = 1; i <= cntNums; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumsSum += num;
                }
                else
                {
                    oddNumsSum += num;
                }
            }

            if (evenNumsSum == oddNumsSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumsSum}");
            }
            else
            {
                Console.WriteLine("No");
                int diff = Math.Abs(evenNumsSum - oddNumsSum);
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
