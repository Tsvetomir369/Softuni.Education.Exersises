using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpent = 0.0;
            string input = Console.ReadLine();
            while (input != "Game Time")
            {
                double price = 0.0;
                switch (input)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        input = Console.ReadLine();
                        continue;
                }

                if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }

                currentBalance -= price;
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else
                {
                    totalSpent += price;
                    Console.WriteLine($"Bought {input}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");

            //if (currentBalance > 0)
            //    {
            //    Console.WriteLine($"Total spent: ${Math.Abs(totalMoney - currentBalance):F2}. Remaining: ${currentBalance:F2}");
            //    }
        }
    }
}
