using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            bool isExcellent = score >= 5.50;

            if (isExcellent)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
