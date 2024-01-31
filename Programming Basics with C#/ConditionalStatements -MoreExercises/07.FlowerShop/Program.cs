using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Брой магнолии – цяло число в интервала[0 … 50]
            //Брой зюмбюли – цяло число в интервала[0 … 50]
            //Брой рози – цяло число в интервала[0 … 50]
            //Брой кактуси – цяло число в интервала[0 … 50]
            //Цена на подаръка – реално число в интервала[0.00 … 500.00]
            int cntMagnolias = int.Parse(Console.ReadLine());
            int cntHyacinths = int.Parse(Console.ReadLine());
            int cntRoses = int.Parse(Console.ReadLine());
            int cntCacti = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            //Магнолии – 3.25 лева
            //Зюмбюли – 4 лева
            //Рози – 3.50 лева
            //Кактуси – 8 лева
            //От общата сума, Мария трябва да плати 5 % данъци.
            double totalSum = (cntMagnolias * 3.25) + (cntHyacinths * 4) + (cntRoses * 3.50) + (cntCacti * 8);

            double afterTaxes = totalSum - (totalSum * 0.05);
            double diff = Math.Abs(afterTaxes - giftPrice);
            if (afterTaxes >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva.");
            }
        }
    }
}
