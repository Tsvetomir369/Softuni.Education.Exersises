using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Броят на кучетата – цяло число в интервала[0… 100]
            //Броят на останалите животни  -цяло число в интервала[0… 100]
            int dogsCnt = int.Parse(Console.ReadLine());
            int otherAnimalsCnt = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogsCnt * 2.50;
            double otherFoodPrice = otherAnimalsCnt * 4;

            double totalPrice = dogFoodPrice + otherFoodPrice;

            Console.WriteLine($"{totalPrice} lv.");

            /* int dogsCnt = int.Parse(Console.ReadLine());
            int otherAnimalsCnt = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(dogsCnt * 2.50) + (otherAnimalsCnt * 4)} lv.");*/
        }
    }
}
