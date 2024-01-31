using System;

namespace _10.Clock_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int k = 0; k <= 59; k++)
                {
                    for (int j = 0; j <= 59; j++)
                    {
                        Console.WriteLine($"{i} : {k} : {j}");
                    }
                }
            }
        }
    }
}
