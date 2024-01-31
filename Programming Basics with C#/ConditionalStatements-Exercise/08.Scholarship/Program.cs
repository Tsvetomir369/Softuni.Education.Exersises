using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Доход в лева - реално число в интервала[0.00..6000.00]
            //Среден успех -реално число в интервала[2.00...6.00]
            //Минимална работна заплата - реално число в интервала[0.00..1000.00]

            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholoraship = Math.Floor(minimalSalary * 0.35);
            double excellentScholraship = Math.Floor(averageGrade * 25);
            bool forSocial = (income < minimalSalary && averageGrade > 4.5);
            bool forExcellent = (averageGrade >= 5.50);

            if (forExcellent)
            {
                if (excellentScholraship >= socialScholoraship || income > minimalSalary)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentScholraship} BGN");
                }
                else 
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholoraship} BGN");
                }
            }
            else if (forSocial)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholoraship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
