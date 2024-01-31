using System;

namespace _04.NumbersDividedBy3WithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }
}
