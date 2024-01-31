using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            int[] roundednNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundednNums[i] = (int)Math
                    .Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(nums[i])} => {Convert.ToDecimal(roundednNums[i])}");
            }
        }
    }
}
