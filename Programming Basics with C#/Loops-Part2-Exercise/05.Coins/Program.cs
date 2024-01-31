using System;

namespace _05.Coins
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double exchange = double.Parse(Console.ReadLine());
            double newExchange = Math.Floor(exchange * 100);
            int cntCoins = 0;

            while (newExchange > 0)
            {
                if (newExchange - 200 >= 0)
                {
                    newExchange -= 200;
                    cntCoins++;
                }
                else if (newExchange - 100 >= 0)
                {
                    newExchange -= 100;
                    cntCoins++;
                }
                else if (newExchange - 50 >= 0)
                {
                    newExchange -= 50;
                    cntCoins++;
                }
                else if (newExchange - 20 >= 0)
                {
                    newExchange -= 20;
                    cntCoins++;
                }
                else if (newExchange - 10 >= 0)
                {
                    newExchange -= 10;
                    cntCoins++;
                }
                else if (newExchange - 5 >= 0)
                {
                    newExchange -= 5;
                    cntCoins++;
                }
                else if (newExchange - 2 >= 0)
                {
                    newExchange -= 2;
                    cntCoins++;
                }
                else
                {
                    newExchange -= 1;
                    cntCoins++;
                }
            }
            Console.WriteLine(cntCoins);
        }
    }
}
