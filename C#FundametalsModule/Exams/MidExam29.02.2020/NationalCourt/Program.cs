using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            //per hour
            int peopleCount = int.Parse(Console.ReadLine());

            int hours = 0;
            
            int perHour = firstEmployee + secondEmployee + thirdEmployee;

            while (peopleCount > 0)
            {
                peopleCount -= perHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
            
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
