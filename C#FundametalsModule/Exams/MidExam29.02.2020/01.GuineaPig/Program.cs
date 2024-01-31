using System;

namespace _01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodInKg = double.Parse(Console.ReadLine());
            double hayInKg = double.Parse(Console.ReadLine());
            double coverInKg = double.Parse(Console.ReadLine());
            double guineaWeightInKg = double.Parse(Console.ReadLine());

            decimal foodInGrams = (decimal)(foodInKg * 1000);
            decimal hayInGrams = (decimal)(hayInKg * 1000);
            decimal coverInGrams = (decimal)(coverInKg * 1000);
            decimal guineaInGrams = (decimal)(guineaWeightInKg * 1000);

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;
                if (i % 2 == 0)
                {
                    hayInGrams -= (foodInGrams * 0.05m);
                }

                if (i % 3 == 0)
                {
                    coverInGrams -= (guineaInGrams / 3);
                }
            }

            if (foodInGrams < 0 || hayInGrams < 0 || coverInGrams < 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodInGrams/1000):f2}, Hay: {(hayInGrams/1000):f2}, Cover: {(coverInGrams/1000):f2}.");
            }
        }
    }   
}
