using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int cntPuzzles = int.Parse(Console.ReadLine());
            int cntTalkingDolls = int.Parse(Console.ReadLine());
            int cntTeddyBears = int.Parse(Console.ReadLine());
            int cntMignons = int.Parse(Console.ReadLine());
            int cntTrucks = int.Parse(Console.ReadLine());

            int allTotalCntToys = cntPuzzles + cntTalkingDolls + cntTeddyBears + cntMignons + cntTrucks;
            //Пъзел - 2.60 лв.
            //Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
            //Миньон - 8.20 лв.
            //Камионче - 2 лв

            double pricePuzzles = cntPuzzles * 2.60;
            double priceTalkingDolls = cntTalkingDolls * 3;
            double priceTeddyBears = cntTeddyBears * 4.10;
            double priceMignons = cntMignons * 8.20;
            double priceTrucks = cntTrucks * 2;

            double allSum = pricePuzzles + priceTalkingDolls + priceTeddyBears + priceMignons + priceTrucks;

            if (allTotalCntToys >= 50)
            {
                allSum = allSum - (allSum * 0.25);
            }

            allSum = allSum - (allSum * 0.1);

            double diff = Math.Abs(allSum - priceTrip);
            if (allSum >= priceTrip)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }
        }
    }
}
