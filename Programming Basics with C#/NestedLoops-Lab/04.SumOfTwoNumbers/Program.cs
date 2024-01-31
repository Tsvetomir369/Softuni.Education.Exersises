using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int cntCombinations = 0;
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            
            for (int first = begin; first <= end; first++)
            {               
                for (int second = begin; second <= end; second++)
                {
                    cntCombinations++;
                    result = first + second;
                    if (result == magicNum)
                    {
                        Console.WriteLine($"Combination N:{cntCombinations} ({first} + {second} = {magicNum})");
                        return;
                    }                    
                }
            }

            if (result != magicNum)
            { 
                Console.WriteLine($"{cntCombinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
