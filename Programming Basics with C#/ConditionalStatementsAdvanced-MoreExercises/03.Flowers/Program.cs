using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
            //На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
            //На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
            //На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            //На петия ред е посочено дали денят е празник – [Y – да / N - не]

            int cntChrysanthemum = int.Parse(Console.ReadLine());
            int cntRoses = int.Parse(Console.ReadLine());
            int cntTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double priceChrysanthemum = 0.0;
            double priceRoses = 0.0;
            double priceTulips = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceChrysanthemum = cntChrysanthemum * 2;
                    priceRoses = cntRoses * 4.10;
                    priceTulips = cntTulips * 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    priceChrysanthemum = cntChrysanthemum * 3.75;
                    priceRoses = cntRoses * 4.50;
                    priceTulips = cntTulips * 4.15;
                    break;
                default:
                    break;
            }

            double priceBouquet = priceChrysanthemum + priceRoses + priceTulips;

            switch (holiday)
            {
                case 'Y':
                    priceBouquet += priceBouquet * 0.15;
                    break;
                default:
                    break;
            }

            if (cntTulips > 7 && season.Equals("Spring"))
            {
                priceBouquet -= priceBouquet * 0.05;
            }

            if (cntRoses >= 10 && season.Equals("Winter"))
            {
                priceBouquet -= priceBouquet * 0.1;
            }

            if ((cntRoses + cntTulips + cntChrysanthemum) > 20)
            {
                priceBouquet -= priceBouquet * 0.2;
            }

            double afterArraging = priceBouquet + 2;

            Console.WriteLine($"{afterArraging:f2}");
        }
    }
}
