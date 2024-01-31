using System;

namespace _08.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFuel = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());

            switch (typeFuel)
            {
                case "Diesel":
                case "Gasoline":
                case "Gas":
                    if (litersFuel >= 25)
                    {
                        Console.WriteLine($"You have enough {typeFuel.ToLower()}.");
                    }
                    else
                    {
                        Console.WriteLine($"Fill your tank with {typeFuel.ToLower()}!");
                    }
                    break;
                default:
                    Console.WriteLine($"Invalid fuel!");
                    break;
            }
        }
    }
}
