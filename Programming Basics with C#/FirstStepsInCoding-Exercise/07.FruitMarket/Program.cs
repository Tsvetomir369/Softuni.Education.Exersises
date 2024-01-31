using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRasberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());

            double priceRasberries = priceStrawberries / 2;
            double priceOranges = priceRasberries - (priceRasberries * 0.4);
            double priceBananas = priceRasberries - (priceRasberries * 0.8);

            double sumRasberries = quantityRasberries * priceRasberries;
            double sumOranges = quantityOranges * priceOranges;
            double sumBananas = quantityBananas * priceBananas;
            double sumStrawberries = quantityStrawberries * priceStrawberries;

            double totalSumNeed = sumRasberries + sumOranges + sumBananas + sumStrawberries;

            Console.WriteLine($"{totalSumNeed:f2}");
        }
    }
}
