using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //Пети ред – килограма миди. Цяло число в интервала[0... 100]
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoQuantity = double.Parse(Console.ReadLine());
            double saurelQuantity = double.Parse(Console.ReadLine());
            int musselsQuantity = int.Parse(Console.ReadLine());

            double bonitoPrice = mackerelPrice + (mackerelPrice * 0.6);
            double bonitoTotalPrice = bonitoPrice * bonitoQuantity;
            double saurelPrice = spratPrice + (spratPrice * 0.8);
            double saurelTotalPrice = saurelPrice * saurelQuantity;
            double musselsTotalPrice = musselsQuantity * 7.50;

            double totalSumAll = bonitoTotalPrice + saurelTotalPrice + musselsTotalPrice;
            Console.WriteLine($"{totalSumAll:f2}");
        }
    }
}
