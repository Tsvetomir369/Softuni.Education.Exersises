using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            string num = string.Empty;

            for (int i = 0; i <= inputNum.Length; i++)
            {
                num += inputNum[i];
                Console.WriteLine(num);
            }
        }
    }
}