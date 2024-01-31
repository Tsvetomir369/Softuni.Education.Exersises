using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntCombinations = 0;
            int numN = int.Parse(Console.ReadLine()); 
            for (int first = 0; first <= numN; first++)
            {
                for (int second = 0; second <= numN; second ++)
                {
                    for (int third = 0; third <= numN; third ++)
                    {
                        int combination = first + second + third;
                        if (combination == numN)
                        {
                            cntCombinations++;                           
                        }
                    }
                }
            }
            Console.WriteLine(cntCombinations);
        }
    }
}
