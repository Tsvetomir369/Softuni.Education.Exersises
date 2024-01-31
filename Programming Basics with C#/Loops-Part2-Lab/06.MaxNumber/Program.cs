using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (maxNum < inputNum)
                {
                    maxNum = inputNum;
                }
                n--;
            }

            Console.WriteLine(maxNum);
        }
    }
}
