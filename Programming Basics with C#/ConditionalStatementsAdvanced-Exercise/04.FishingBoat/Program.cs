using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет на групата – цяло число в интервала[1…8000]
            // Сезон – текст: "Spring","Summer","Autumn","Winter"
            // Брой рибари – цяло число в интервала[4…18]

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int cntFishers = int.Parse(Console.ReadLine());

            double shipRent = 0.0;

            switch (season)
            {
                case "Spring":
                    shipRent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipRent = 4200;
                    break;
                case "Winter":
                    shipRent = 2600;
                    break;
                default:
                    break;
            }

            if (cntFishers <= 6)
            {
                shipRent -= shipRent * 0.1;
            }
            else if (cntFishers >= 7 && cntFishers <= 11)
            {
                shipRent -= shipRent * 0.15;
            }
            else
            {
                shipRent -= shipRent * 0.25;
            }

            if (cntFishers % 2 == 0 && !season.Equals("Autumn"))
            {
                shipRent -= shipRent * 0.05;
            }

            double diff = Math.Abs(budget - shipRent);
            if (shipRent <= budget)
            {
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
            }
        }
    }
}
