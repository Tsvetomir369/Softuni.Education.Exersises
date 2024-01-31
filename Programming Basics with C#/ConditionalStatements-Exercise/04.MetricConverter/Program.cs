using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numMetric = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            switch (inputMetric)
            {
                case "m":
                    numMetric /= 1;
                    break;
                case "cm":
                    numMetric /= 100;
                    break;
                case "mm":
                    numMetric /= 1000;
                    break;
                default:
                    break;
            }

            switch (outputMetric)
            {
                case "m":
                    numMetric *= 1;
                    break;
                case "cm":
                    numMetric *= 100;
                    break;
                case "mm":
                    numMetric *= 1000;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{numMetric:f3}");
        }
    }
}
