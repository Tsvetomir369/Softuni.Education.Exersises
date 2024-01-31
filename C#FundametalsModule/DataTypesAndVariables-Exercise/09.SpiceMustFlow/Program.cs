using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //totalAmount
            byte days = 0;
            int total = 0;
            int startingYield = int.Parse(Console.ReadLine());
            while (startingYield >= 100)
            {
                int leaving = startingYield - 26;
                total += leaving;
                startingYield -= 10;
                days++;
            }

            if (total > 26)
            {
                total -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(total);
        }
    }
}
