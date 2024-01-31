using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketPrice = 0;

            if (0 <= age && age <= 18)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = 12;
                        break;
                    case "Weekend":
                        ticketPrice = 15;
                        break;
                    case "Holiday":
                        ticketPrice = 5;
                        break;
                    default:
                        break;
                }
            }
            else if (18 < age && age <= 64)
            {
                switch (typeOfDay)
                {
                    case "Weekday":
                        ticketPrice = 18;
                        break;
                    case "Weekend":
                        ticketPrice = 20;
                        break;
                    case "Holiday":
                        ticketPrice = 12;
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                if (64 < age && age <= 122)
                {
                    switch (typeOfDay)
                    {
                        case "Weekday":
                            ticketPrice = 12;
                            break;
                        case "Weekend":
                            ticketPrice = 15;
                            break;
                        case "Holiday":
                            ticketPrice = 10;
                            break;
                        default:
                            break;
                    }
                }  
            }

            if (ticketPrice != 0)
            {
                Console.WriteLine("{0}$", ticketPrice);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}