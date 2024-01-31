using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte nLines = sbyte.Parse(Console.ReadLine());
            double maxVolume = 0.0;
            string biggestKeg = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }               
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
