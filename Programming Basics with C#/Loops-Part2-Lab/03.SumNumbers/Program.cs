using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int numInput = int.Parse(input);
                sum += numInput;
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
