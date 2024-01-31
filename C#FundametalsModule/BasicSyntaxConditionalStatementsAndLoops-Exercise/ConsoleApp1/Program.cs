using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = num;
            int sumFactorials = 0;
            while (current != 0)
            {
                int factorial = 1;
                int digit = current % 10;
                current /= 10;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sumFactorials += factorial;
            }
            if (sumFactorials == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
