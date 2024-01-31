using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrixFromNumber(n);
        }

        static int PrintMatrixFromNumber(int n)
        {
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    number = n;
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            return number;
        }
    }
}
