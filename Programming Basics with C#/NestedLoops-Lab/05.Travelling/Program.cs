using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySaved = 0.0;
            string destination = Console.ReadLine();            
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                while (minBudget > moneySaved)
                {
                    double money = double.Parse(Console.ReadLine());
                    moneySaved += money;
                    if (minBudget <= moneySaved)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        moneySaved = 0.0;
                        break;
                    }
                }
                destination = Console.ReadLine();
            }
        }
    }
}
