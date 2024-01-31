using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTown = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine("Town {0} has population of {1} and area {2} square km.",nameTown, population, area);
        }
    }
}
