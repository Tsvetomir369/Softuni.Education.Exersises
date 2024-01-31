using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            //into kilometers 
            //1m = 0.001km
            decimal kilometers = meters / 1000m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
