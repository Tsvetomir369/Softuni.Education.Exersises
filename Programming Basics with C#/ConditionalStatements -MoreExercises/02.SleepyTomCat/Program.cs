using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntHolidayDays = int.Parse(Console.ReadLine());

            int whenWork = (365 - cntHolidayDays) * 63;
            int whenHoliday = cntHolidayDays * 127;

            int catNormPerYear = 30000;

            int playTime = whenHoliday + whenWork;
            int diff = Math.Abs(playTime - catNormPerYear);

            if (playTime > catNormPerYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diff/60} hours and {diff % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diff / 60} hours and {diff % 60} minutes less for play");
            }
        }
    }
}
