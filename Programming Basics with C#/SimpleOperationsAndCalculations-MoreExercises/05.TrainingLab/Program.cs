using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lengthCm = length * 100;
            double widthCm = width * 100;

            double desks = Math.Floor((widthCm - 100) / 70);
            double rows = Math.Floor(lengthCm / 120);
            double totalPlaces = (desks * rows) - 3;
            Console.WriteLine(totalPlaces);
        }
    }
}
