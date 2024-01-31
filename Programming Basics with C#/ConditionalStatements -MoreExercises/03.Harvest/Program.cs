using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            //2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            //3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            //4ти ред: брой работници – цяло число в интервала[1 … 20]
            int squareMetersX = int.Parse(Console.ReadLine());
            double grapesPerSquareMeterY = double.Parse(Console.ReadLine());
            int letersNeedWineZ = int.Parse(Console.ReadLine());
            int cntWorkers = int.Parse(Console.ReadLine());

            double totalGrapesHarvest = squareMetersX * grapesPerSquareMeterY;
            double totalWine = (totalGrapesHarvest * 0.40) / 2.5;
            double diff = Math.Abs(totalWine - letersNeedWineZ);
            double littersPererson = diff / cntWorkers;

            if (totalWine < letersNeedWineZ)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(littersPererson)} liters per person.");
            }
        }
    }
}
