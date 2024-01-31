using System;

namespace _05.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = (hour * 60) + minutes;
            int timeAfter15minutes = timeInMinutes + 15;

            int newHour = timeAfter15minutes / 60;
            int newminutes = timeAfter15minutes % 60;

            if (newHour >= 24)
            {
                newHour = 0;
            }

            if (newminutes < 10)
            {
                Console.WriteLine($"{newHour}:0{newminutes}");
            }
            else
            {
                Console.WriteLine($"{newHour}:{newminutes}");
            }
        }
    }
}
