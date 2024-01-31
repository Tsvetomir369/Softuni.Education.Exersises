using System;

namespace _08.FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double priceDiesel = 2.33;
            double priceGasoline = 2.22;
            double priceGas = 0.93;
            double priceTotal = 0.0;

            switch (clubCard)
            {
                case "Yes":
                    switch (typeFuel)
                    {
                        case "Diesel":
                            priceTotal = (priceDiesel - 0.12) * litersFuel;
                            break;
                        case "Gasoline":
                            priceTotal = (priceGasoline - 0.18) * litersFuel;
                            break;
                        case "Gas":
                            priceTotal = (priceGas - 0.08) * litersFuel;
                            break;
                        default:
                            break;
                    }
                    break;
                case "No":
                    switch (typeFuel)
                    {
                        case "Diesel":
                            priceTotal = priceDiesel * litersFuel;
                            break;
                        case "Gasoline":
                            priceTotal = priceGasoline * litersFuel;
                            break;
                        case "Gas":
                            priceTotal = priceGas * litersFuel;
                            break;
                        default:
                            break;
                    }
                    break;
            }

            if (litersFuel >= 20 && litersFuel <= 25)
            {
                priceTotal -= priceTotal * 0.08;
            }

            if (litersFuel > 25)
            {
                priceTotal -= priceTotal * 0.1;
            }

            Console.WriteLine($"{priceTotal:f2} lv.");
        }
    }
}
