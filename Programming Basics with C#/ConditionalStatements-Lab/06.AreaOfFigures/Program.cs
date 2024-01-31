using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] ars)
        {
            string typeFigure = Console.ReadLine();
            double area = 0.0;

            switch (typeFigure)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    area = side * side;
                    break;
                case "rectangle":
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    area = side1 * side2;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "triangle":
                    double sideLenght = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = (sideLenght * height) / 2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
