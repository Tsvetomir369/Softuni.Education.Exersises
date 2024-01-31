using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Брой на статистите – цяло число в интервала[1 … 500]
            //Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            double budgetMovie = double.Parse(Console.ReadLine());
            int cntStatisticians = int.Parse(Console.ReadLine());
            double dressPerOneStatistiacian = double.Parse(Console.ReadLine());

            double decor = budgetMovie * 0.1;
            double pricePerAllDress = dressPerOneStatistiacian * cntStatisticians;

            if (cntStatisticians > 150)
            {
                pricePerAllDress -= pricePerAllDress * 0.1;
            }

            double totalSumAll = decor + pricePerAllDress;
            double diff = Math.Abs(totalSumAll - budgetMovie);

            if (totalSumAll > budgetMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {diff:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {diff:f2} leva left.");
            }
        }
    }
}
