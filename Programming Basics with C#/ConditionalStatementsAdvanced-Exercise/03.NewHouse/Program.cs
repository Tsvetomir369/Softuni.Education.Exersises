using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вид цветя -текст с възможности -"Roses","Dahlias","Tulips","Narcissus","Gladiolus";
            // Брой цветя -цяло число в интервала[10…1000]
            // Бюджет - цяло число в интервала
            string typeFlowers = Console.ReadLine();
            int cntFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            switch (typeFlowers)
            {
                case "Roses":
                    totalPrice = cntFlowers * 5;
                    if (cntFlowers > 80)
                    {
                        double discount = totalPrice * 0.1;
                        totalPrice -= discount;
                    }
                    break;
                case "Dahlias":
                    totalPrice = cntFlowers * 3.80;
                    if (cntFlowers > 90)
                    {
                        double discount = totalPrice * 0.15;
                        totalPrice -= discount;
                    }
                    break;
                case "Tulips":
                    totalPrice = cntFlowers * 2.80;
                    if (cntFlowers > 80)
                    {
                        double discount = totalPrice * 0.15;
                        totalPrice -= discount;
                    }
                    break;
                case "Narcissus":
                    totalPrice = cntFlowers * 3;
                    if (cntFlowers < 120)
                    {
                        totalPrice += totalPrice * 0.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = cntFlowers * 2.50;
                    if (cntFlowers < 80)
                    {
                        totalPrice += totalPrice * 0.2;
                    }
                    break;
                default:
                    break;
            }

            double diff = Math.Abs(totalPrice - budget);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {cntFlowers} {typeFlowers} and {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff:f2} leva more.");
            }
        }
    }
}
