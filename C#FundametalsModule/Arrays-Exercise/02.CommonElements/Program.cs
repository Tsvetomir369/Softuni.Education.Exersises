using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()
                .Split();

            var secondArr = Console.ReadLine()
                .Split();

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        Console.Write($"{secondArr[i]} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
