using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Депозирана сума – реално число в интервала[100.00 … 10000.00];
            //Срок на депозита(в месеци) – цяло число в интервала[1…12];
            //Годишен лихвен процент – реално число в интервала[0.00 …100.00];
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double totalSum = deposit + (months * ((deposit * (interestRate/100)) / 12));
            //double accruedInterest = (deposit * interestRate) / 100;
            //double perMonth = accruedInterest / 12;
            //double totalSum = deposit + (months * perMonth);

            Console.WriteLine(totalSum);
        }
    }
}
