using System;

namespace _06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – Сезон – текст "Spring", "Summer", "Autumn" или "Winter"
            //Втори ред –  Километри на месец – реално число в интервала[10.00...20000.00]

            string season = Console.ReadLine();
            double miles = double.Parse(Console.ReadLine());

            double payment = 0.0;

            if (miles <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        payment = miles * 0.75;
                        break;
                    case "Summer":
                        payment = miles * 0.90;
                        break;
                    case "Winter":
                        payment = miles * 1.05;
                        break;
                    default:
                        break;
                }
            }
            else if (miles <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        payment = miles * 0.95;
                        break;
                    case "Summer":
                        payment = miles * 1.10;
                        break;
                    case "Winter":
                        payment = miles * 1.25;
                        break;
                    default:
                        break;
                }
            }
            else if (miles <= 20000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                    case "Summer":
                    case "Winter":
                        payment = miles * 1.45;
                        break;
                    default:
                        break;
                }
            }
            payment *= 4;
            double afterTaxes = payment - (payment * 0.1);

            Console.WriteLine($"{afterTaxes:f2}");
        }
    }
}
