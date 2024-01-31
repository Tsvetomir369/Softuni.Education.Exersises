using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0.0;
            switch (dayOfWeek)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16.00;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            double totalPrice = cntPeople * price;
            switch (typeOfGroup)
            {
                case "Students":
                    if (cntPeople >= 30)
                    {
                        totalPrice -= totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    if (cntPeople >= 100)
                    {
                        totalPrice -= price * 10;
                    }
                    break;
                case "Regular":
                    if (cntPeople >= 10 && cntPeople <= 20)
                    {
                        totalPrice -= totalPrice * 0.05;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total price: {0:f2}", totalPrice);
        }
    }
}
