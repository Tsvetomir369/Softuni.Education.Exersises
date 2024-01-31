using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            string input = Console.ReadLine();
            while ((input != "special") && (input != "regular"))
            {
                double prices = double.Parse(input);
                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += prices;
                }
                input = Console.ReadLine();
            }

            double taxes = (totalPrice * 0.2);
            double afterTaxes = totalPrice + taxes;
            double specialTaxes = afterTaxes * 0.1;

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (input == "special")
            {
                afterTaxes -= specialTaxes;

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {afterTaxes:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {afterTaxes:f2}$");
            }
        }
    }
}
