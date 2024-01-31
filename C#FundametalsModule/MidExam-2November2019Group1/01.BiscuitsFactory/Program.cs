using System;

namespace _01.BiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //per 1 worker biscuits
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int otherFactory = int.Parse(Console.ReadLine());

            int totalProduction = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    if (biscuitsPerDay != 1)
                    {
                        totalProduction += (int)(biscuitsPerDay * countWorkers * 0.75);
                    }
                }
                else
                {
                    totalProduction += biscuitsPerDay * countWorkers;
                }

            }

            int diff = Math.Abs(otherFactory - totalProduction);
            decimal percentage = (diff / (decimal)otherFactory) * 100;
            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");
            string sign = "more";
            if (otherFactory > totalProduction)
            {
                sign = "less";
            }

            Console.WriteLine($"You produce {percentage:F2} percent {sign} biscuits.");
        }
    }
}
