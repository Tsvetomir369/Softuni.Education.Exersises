using System;
using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= inputNum; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
