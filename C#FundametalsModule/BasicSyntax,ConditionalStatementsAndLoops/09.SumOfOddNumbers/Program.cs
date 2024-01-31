using System;

namespace _09.SumOfOdNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            for (int i = 1; i <= nNum; i++)
            {
                Console.WriteLine("{0}", (i * 2) - 1);
                sumOdd += (i * 2) - 1;
            }
            Console.WriteLine("Sum: {0}", sumOdd);
        }
    }
}
