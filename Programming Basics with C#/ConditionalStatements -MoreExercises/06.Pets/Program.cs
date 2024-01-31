using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – брой дни – цяло число в интервал[1…5000]
            //Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]
            int cntDays = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodDogPerDay = double.Parse(Console.ReadLine());
            double foodCatPerDay = double.Parse(Console.ReadLine());
            double foodTurtlePerDay = double.Parse(Console.ReadLine());

            double foodAllNeed = (foodCatPerDay + foodDogPerDay + (foodTurtlePerDay / 1000)) * cntDays;
            double diff = Math.Abs(foodAllNeed - foodLeft);
            if (foodLeft >= foodAllNeed)
            {
                Console.WriteLine($"{Math.Floor(diff)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(diff)} more kilos of food are needed.");
            }
        }
    }
}
