using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());

            double timeIvan = distance * timePerMeterInSeconds;
            double resistance = Math.Floor(distance / 15) * 12.5;
            double totalTime = timeIvan + resistance;

            double diff = Math.Abs(totalTime - recordInSeconds);
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }
        }
    }
}
