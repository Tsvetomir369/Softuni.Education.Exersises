using System;

namespace _02.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
            //Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
            //Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"
            int cntJunior = int.Parse(Console.ReadLine());
            int cntSenior = int.Parse(Console.ReadLine());
            string routeType = Console.ReadLine();

            decimal priceTicketJunior = 0.0m;
            decimal priceTicketSenior = 0.0m;

            switch (routeType)
            {
                case "trail":
                    priceTicketJunior = cntJunior * 5.50m;
                    priceTicketSenior = cntSenior * 7m;
                    break;
                case "cross-country":
                    priceTicketJunior = cntJunior * 8m;
                    priceTicketSenior = cntSenior * 9.50m;
                    break;
                case "downhill":
                    priceTicketJunior = cntJunior * 12.25m;
                    priceTicketSenior = cntSenior * 13.75m;
                    break;
                case "road":
                    priceTicketJunior = cntJunior * 20;
                    priceTicketSenior = cntSenior * 21.50m;
                    break;
                default:
                    break;
            }

            decimal allAmount = priceTicketJunior + priceTicketSenior;

            if (routeType == "cross-country" && (cntJunior + cntSenior) >= 50)
            {
                allAmount -= allAmount * 0.25m;
            }

            decimal afterCost = allAmount - (allAmount * 0.05m);

            Console.WriteLine($"{afterCost:f2}");
        }
    }
}

