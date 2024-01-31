using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearIvancho = 18;
            double bequest = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            for (int i = 1800; i <= year; i++)
            {               
                if (i % 2 == 0)
                {
                    bequest -= 12000;
                }
                else
                {
                    bequest -= 12000 + (50 * yearIvancho);
                }
                yearIvancho++;
            }

            if (bequest >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {bequest:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(bequest):f2} dollars to survive.");
            }
        }
    }
}
