using System;

namespace _03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;

            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;

            double n = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");

            if (oddMin == 2147483647)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }

            if (oddMax == -2147483648)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMin == 2147483647)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }

            if (evenMax == -2147483648)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
