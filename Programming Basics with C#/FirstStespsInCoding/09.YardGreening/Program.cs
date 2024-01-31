using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            //Кв. метри, които ще бъдат озеленени – реално число в интервала [0.00… 10000.00]
            decimal squareMeters = decimal.Parse(Console.ReadLine());
            //price per one square meter = 7.61
            decimal price = squareMeters * 7.61m;
            decimal discount = price * 0.18m;
            decimal totalPrice = price - discount;

            Console.WriteLine($"The final price is: {totalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
