using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n >= 1)
            {
                int[] mainArr = new int[n];
                for (int i = 1; i < n; i++)
                {
                    
                }
                int[] newArr = new int[mainArr.Length];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = mainArr[i + 1];
                }
                mainArr = newArr;
                n --;
            }

            Console.WriteLine($"{mainArr} ");
        }
    }
}
