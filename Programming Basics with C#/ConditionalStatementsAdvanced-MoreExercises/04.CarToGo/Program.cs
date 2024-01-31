using System;

namespace _04.CarToGo
{
    class Prgram
    {
        static void Main(string[] args)
        {
            //Първи ред – Бюджет – реално число в интервала[10.00...10000.00]
            //Втори ред –  Сезон – текст "Summer" или "Winter"
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");

                    switch (season)
                {
                    case "Summer":
                        budget = budget * 0.35;
                        Console.WriteLine($"Cabrio - {budget:f2}");
                        break;
                    case "Winter":
                        budget = budget * 0.65;
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                    default:
                        break;
                }
            }
            else if (budget <= 500)
            {
                Console.WriteLine("Compact class");

                    switch (season)
                {
                    case "Summer":
                        budget = budget * 0.45;
                        Console.WriteLine($"Cabrio - {budget:f2}");
                        break;
                    case "Winter":
                        budget = budget * 0.8;
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Luxury class");

                switch (season)
                {
                    case "Summer":
                    case "Winter":
                        budget = budget * 0.9;
                        Console.WriteLine($"Jeep - {budget:f2}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
