using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntPayment = 0;
            int payCash = 0;
            int cntWithCash = 0;
            int payCard = 0;
            int cntWithCard = 0;
            int collectedSum = 0;
            bool areCollected = false;
            int amountExpected = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                int priceProducts = int.Parse(inputCommand);
                cntPayment++;
                if (cntPayment % 2 == 0)
                {
                    if (priceProducts < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        payCard += priceProducts;
                        cntWithCard++;
                    }
                }
                else
                {
                    if (priceProducts > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        payCash += priceProducts;
                        cntWithCash++;
                    } 
                }
                collectedSum = payCard + payCash;
                if (collectedSum >= amountExpected)
                {
                    areCollected = true;
                    break;
                }
                inputCommand = Console.ReadLine();
            }

            //if (inputCommand == "End")
            //{
            //    Console.WriteLine("Failed to collect required money for charity.");
            //}

            if (areCollected)
            {
                double averageCash = payCash * 1.0 / cntWithCash;
                Console.WriteLine($"Average CS: {averageCash:f2}");
                double averageCard = payCard * 1.0 / cntWithCard;
                Console.WriteLine($"Average CC: {averageCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
