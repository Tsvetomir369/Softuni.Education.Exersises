using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 1;
            bool isBigger = false;
            int n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int colums = 1; colums <= rows; colums++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
