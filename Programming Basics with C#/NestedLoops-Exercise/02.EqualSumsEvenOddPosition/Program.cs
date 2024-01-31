using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int evenSum = 0;
                int oddSum = 0;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    oddSum += currentNumber % 10;
                    currentNumber /= 10;
                    evenSum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
            //Other Decision***

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());

            //for (int i = number1; i <= number2; i++)
            //{
            //    string current = i.ToString();
            //    int evenSum = 0;
            //    int oddSum = 0;
            //    for (int j = 0; j < current.Length; j++)
            //    {
            //        int currentDigit = int.Parse(current[j].ToString());

            //        if (j % 2 == 0)
            //        {
            //            evenSum += currentDigit;
            //        }
            //        else
            //        {
            //            oddSum += currentDigit;
            //        }
            //    }

            //    if (evenSum == oddSum)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
        }
    }
}
