using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[]args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double totalVegetables = double.Parse(Console.ReadLine());
            double totalFruits = double.Parse(Console.ReadLine());

            double totalPriceAll = ((priceFruits * totalFruits) + (priceVegetables * totalVegetables)) / 1.94;
            Console.WriteLine($"{totalPriceAll:f2}");
        }
    }
}
