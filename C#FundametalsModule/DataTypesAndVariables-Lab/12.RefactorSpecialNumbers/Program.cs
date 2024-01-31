using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());

            for (int num = 1; num <= inputN; num++)
            {
                int sumOfDigits = 0;
                int digit = num;
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
