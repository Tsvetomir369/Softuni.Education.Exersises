using System;

namespace _08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int oddSum = 0;
            int diff = 0;
            bool areTheSumsEquals = true;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = num1 + num2;
                }
                else
                {
                    oddSum = num1 + num2;
                }

                if (i > 1 && Math.Abs(oddSum - evenSum) > diff)
                {
                    diff = Math.Abs(evenSum - oddSum);
                    areTheSumsEquals = false;
                }
            }

            if (areTheSumsEquals == true)
            {
                Console.WriteLine($"Yes, value={oddSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
