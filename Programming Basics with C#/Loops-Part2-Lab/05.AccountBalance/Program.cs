using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankAccount = 0.0;
            int cntPayments = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= cntPayments)
            {
                double inputPayment = double.Parse(Console.ReadLine());

                if (inputPayment < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {inputPayment:f2}");
                bankAccount += inputPayment;
                i++;
            }

            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
