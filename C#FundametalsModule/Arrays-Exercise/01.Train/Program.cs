using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntWagons = int.Parse(Console.ReadLine());

            int[] peopleInWagons = new int[cntWagons];
            int allPeople = 0;
            for (int i = 0; i < cntWagons; i++)
            {
                int cntPeople = int.Parse(Console.ReadLine());
                peopleInWagons[i] += cntPeople;
                allPeople += cntPeople;
            }

            Console.WriteLine(string.Join(' ', peopleInWagons));
            Console.WriteLine(allPeople);
        }
    }
}
