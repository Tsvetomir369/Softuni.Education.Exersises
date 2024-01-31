using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            int nNums = int.Parse(Console.ReadLine());
            for (int i = 0; i < nNums; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > maxNum)
                {
                    maxNum = input;
                }

                if (input < minNum)
                {
                    minNum = input;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
