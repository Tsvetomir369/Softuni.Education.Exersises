using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int inputNum = int.Parse(Console.ReadLine());
                if (minNum > inputNum)
                {
                    minNum = inputNum;
                }
                n--;
            }

            Console.WriteLine(minNum);
        }
    }
}
