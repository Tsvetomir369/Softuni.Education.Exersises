using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //x – височината на къщата – реално число в интервала[2...100]
            //y – дължината на страничната стена – реално число в интервала[2...100]
            //h – височината на триъгълната стена на прокрива – реално число в интервала[2...100
            double heightX = double.Parse(Console.ReadLine());
            double lengthSideWallY = double.Parse(Console.ReadLine());
            double heightTriangularWallRoof = double.Parse(Console.ReadLine());

            double frontBackWall =(heightX * heightX) + ((heightX * heightX) - (1.2 * 2));
            double sideWalls = ((heightX * lengthSideWallY) - (1.5 * 1.5)) * 2;
            double roofRectangularSide = 2 * (heightX * lengthSideWallY);
            double roofTriangularSide = 2 * ((heightX * heightTriangularWallRoof) / 2);

            double greenArea = frontBackWall + sideWalls;
            double greenPaint = greenArea / 3.4;
            double redArea = roofRectangularSide + roofTriangularSide;
            double redPaint = redArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
