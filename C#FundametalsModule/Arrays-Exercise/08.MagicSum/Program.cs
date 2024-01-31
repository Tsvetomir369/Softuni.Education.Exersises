using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            int inputN = int.Parse(Console.ReadLine());

            //1 7 6 2 19 23
            //8

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int numSum = array[i] + array[j];
                    if (numSum == inputN)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                        Console.WriteLine();
                    }
                    //if (array[i] + array[j] == inputN)
                    //{
                    //    Console.Write($"{array[i]} {array[j]}");
                    //    Console.WriteLine();
                    //}
                }
            }
        }
    }
}
