using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Брой страници в текущата книга – цяло число в интервала[1…1000];
            //Страници, които може да прочита за 1 час – реално число в интервала[1.00…1000.00];
            //Броя на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000];
            int bookCntPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalTime = bookCntPages / pagesPerHour;
            double needHoursPerDay = totalTime / days;

            Console.WriteLine(needHoursPerDay);
        }
    }
}
