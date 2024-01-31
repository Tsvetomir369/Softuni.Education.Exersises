using System;

namespace _04.Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isUnder100 = (num < 100);
            bool isBetween100And200 = (num >= 100 && num <= 200);
            
            if (isUnder100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (isBetween100And200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
