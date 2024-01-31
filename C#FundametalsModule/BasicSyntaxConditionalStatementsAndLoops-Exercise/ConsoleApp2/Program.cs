using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Until you receive “Start” you will be
            //given different coins that are being inserted in the machine.
            double totalMoney = 0;
            string command = Console.ReadLine();
            while (command != "Start")
            {
                double currentAmount = double.Parse(command);
                if (currentAmount != 0.1 && currentAmount != 0.2  && currentAmount != 0.5 
                    && currentAmount != 1 && currentAmount != 2)
                {
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }
                else
                {
                    totalMoney += currentAmount;
                }
                
                command = Console.ReadLine();
            }

            //On the next few lines until you receive “End” you will be given products to purchase.
            string item = Console.ReadLine();
            while (item != "End")
            {
                double productPrice = 0;
                //“Nuts”, “Water”, “Crisps”, “Soda”, “Coke”.
                //The prices are: 2.0, 0.7, 1.5, 0.8, 1.0
                switch (item)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        item = Console.ReadLine();
                        continue;
                }

                if (totalMoney >= productPrice)
                {
                    totalMoney -= productPrice;
                    Console.WriteLine($"Purchased {item.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                item = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
