using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (numN % m == 0 && numN % l == 0 && numN % k == 0 && numN % i == 0)
                            {
                                Console.Write($"{i}{k}{l}{m} ");
                            }                           
                        }
                    }                                       
                }
            }
        }
    }
}
