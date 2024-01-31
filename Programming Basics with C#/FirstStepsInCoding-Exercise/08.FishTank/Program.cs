using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double area = length * width * height;
            double litres = area * 0.001;
            double totalLitresNeed = litres - (litres * (percent / 100));
            Console.WriteLine($"{totalLitresNeed:f5}");
        }
    }
}
