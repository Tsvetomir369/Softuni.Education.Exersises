using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int cntRows = int.Parse(Console.ReadLine());
            int cntColumns = int.Parse(Console.ReadLine());

            double totalIncomeTickets = 0.0;

            switch (typeProjection)
            {
                case "Premiere":
                    totalIncomeTickets = cntColumns * cntRows * 12.00;
                    break;
                case "Normal":
                    totalIncomeTickets = cntColumns * cntRows * 7.50;
                    break;
                case "Discount":
                    totalIncomeTickets = cntColumns * cntRows * 5.00;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{totalIncomeTickets:f2} leva");
        }
    }
}
