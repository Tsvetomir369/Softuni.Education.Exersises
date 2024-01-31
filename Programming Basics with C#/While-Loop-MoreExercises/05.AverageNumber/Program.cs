using System;

namespace _05.AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0.0;
            int number = 0;
            int inputNum = int.Parse(Console.ReadLine());
            while (inputNum > number)
            {
                int num = int.Parse(Console.ReadLine());
                average += num;
                number++;
            }
            average /= inputNum;
            Console.WriteLine($"{average:f2}");
        }
    }
}