using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int allTicketsSold = 0;
            int cntStudentTickets = 0;
            int standardTickets = 0;
            int cntKidsTickets = 0;
            string movieName = Console.ReadLine();
            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int counter = 0;
                string typeOfTicket = Console.ReadLine();
                while (typeOfTicket != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student":
                            cntStudentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            cntKidsTickets++;
                            break;
                        default:
                            break;
                    }
                    counter++;
                    allTicketsSold++;
                    if (counter == freeSeats)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                double percentage = (counter * 1.0 / freeSeats) * 100;
                Console.WriteLine($"{movieName} - {percentage:f2}% full.");

                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allTicketsSold}");
            Console.WriteLine($"{((cntStudentTickets * 1.0 / allTicketsSold) * 100):f2}% student tickets.");
            Console.WriteLine($"{((standardTickets * 1.0 / allTicketsSold) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((cntKidsTickets * 1.0 / allTicketsSold) * 100):f2}% kids tickets.");
        }
    }
}
