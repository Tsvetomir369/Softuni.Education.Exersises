using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNum; i++)
            {
                IsTopNumber(i);
            }
        }

        static void IsTopNumber (int num)
        {
            int sumOfDigits = 0;
            bool isOdd = false;
            int printNum = num;
            while (num > 0)
            {
                int currentDigit = num % 10;
                //17 (take 7 from it)
                sumOfDigits += currentDigit;
                if (!(currentDigit % 2 == 0))
                {
                    isOdd = true;
                }
                num /= 10;
                //17 (take 1 from it)
            }

            if (sumOfDigits % 8 == 0 && isOdd)
            {
                Console.WriteLine(printNum);
            }
        }
    }
}