using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – Бюджет, реално число в интервала[10.00...5000.00].
            // Втори ред – Един от двата възможни сезона: „summer” или “winter”
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string type = "";
            double moneySpent = 0.0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        moneySpent = budget * 0.3;
                        break;
                    case "winter":
                        type = "Hotel";
                        moneySpent = budget * 0.7;
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        type = "Camp";
                        moneySpent = budget * 0.4;
                        break;
                    case "winter":
                        type = "Hotel";
                        moneySpent = budget * 0.8;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        type = "Hotel";
                        moneySpent = budget * 0.9;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {moneySpent:f2}");
        }
    }
}
