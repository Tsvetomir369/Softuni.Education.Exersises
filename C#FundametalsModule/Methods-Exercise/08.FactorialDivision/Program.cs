using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            decimal result = CalculateFactorial(firstNum) / CalculateFactorial(secondNum);

            Console.WriteLine($"{result:f2}");
        }

        static decimal CalculateFactorial(int num)
        {
            decimal factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
