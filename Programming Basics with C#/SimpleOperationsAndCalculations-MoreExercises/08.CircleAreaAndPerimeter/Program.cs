using System;

namespace _08.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numR = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * numR * numR;
            double perimeterCircle = 2 * (Math.PI * numR);

            Console.WriteLine($"{circleArea:f2}");
            Console.WriteLine($"{perimeterCircle:f2}");
        }
    }
}
