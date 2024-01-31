using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            //one inch = 2.54 centimeters;
            double centimeters = num * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}