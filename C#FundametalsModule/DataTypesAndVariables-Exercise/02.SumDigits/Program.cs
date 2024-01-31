using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int digit = num;
            int sumOfDigit = 0;
            while (digit > 0)
            {
                sumOfDigit += digit % 10;
                digit /= 10;
            }

            Console.WriteLine(sumOfDigit);
        }
    }
}
