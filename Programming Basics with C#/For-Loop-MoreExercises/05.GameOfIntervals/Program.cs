using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0.0;
            double points = 0.0;
            int from0To9Points = 0;
            int from10To19Points = 0;
            int from20To29Points = 0;
            int from30To39Points = 0;
            int from40To50Points = 0;
            int more50orNegative = 0;
            int moves = int.Parse(Console.ReadLine());
            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!(number < 0) && number <= 9)
                {
                    points = 0.2 * number;
                    result += points;
                    from0To9Points++;
                }
                else if (!(number < 0) && number <= 19)
                {
                    points = 0.3 * number;
                    result += points;
                    from10To19Points++;
                }
                else if (!(number < 0) && number <= 29)
                {
                    points = 0.4 * number;
                    result += points;
                    from20To29Points++;
                }
                else if (!(number < 0) && number <= 39)
                {
                    points = 50;
                    result += points;
                    from30To39Points++;
                }
                else if (!(number < 0) && number <= 50)
                {
                    points = 100;
                    result += points;
                    from40To50Points++;
                }
                else
                {
                    result /= 2;
                    more50orNegative++;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {((from0To9Points * 1.0 / moves) * 100):f2}%");
            Console.WriteLine($"From 10 to 19: {((from10To19Points * 1.0 / moves) * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {((from20To29Points * 1.0 / moves) * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {((from30To39Points * 1.0 / moves) * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {((from40To50Points * 1.0 / moves) * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {((more50orNegative * 1.0 / moves) * 100):f2}%");
        }
    }
}
