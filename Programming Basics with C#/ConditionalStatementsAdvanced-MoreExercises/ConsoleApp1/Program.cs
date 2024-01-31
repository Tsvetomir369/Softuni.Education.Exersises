using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
            //На втория ред е категорията – "VIP" или "Normal"
            //На третия ред е броят на хората в групата – цяло число в интервала[1... 200]
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleCnt = int.Parse(Console.ReadLine());

            if (peopleCnt == 1 || peopleCnt <= 4)
            {
                budget = budget - (budget * 0.75);
            }
            else if (peopleCnt == 5 || peopleCnt <= 9)
            {
                budget = budget - (budget * 0.6);
            }
            else if (peopleCnt == 10 || peopleCnt <= 24)
            {
                budget = budget - (budget * 0.5);
            }
            else if (peopleCnt == 25 || peopleCnt <= 49)
            {
                budget = budget - (budget * 0.40);
            }
            else
            {
                budget = budget - (budget * 0.25);
            }

            double priceTicket = 0.0; ;

            switch (category)
            {
                case "VIP":
                    priceTicket = 499.99 * peopleCnt;
                    break;
                case "Normal":
                    priceTicket = 249.99 * peopleCnt;
                    break;
                default:
                    break;
            }

            double diff = Math.Abs(budget - priceTicket);

            if (budget >= priceTicket)
            {
                Console.WriteLine($"Yes! You have {diff:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva.");
            }
        }
    }
}
