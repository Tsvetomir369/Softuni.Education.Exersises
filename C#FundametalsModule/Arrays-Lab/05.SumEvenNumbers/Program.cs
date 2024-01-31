using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] % 2 == 0)
                {
                    even += nums[i];
                }
            }
            Console.WriteLine(even);
        }   
    }
}
