using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte waterTankCapacity = 255;
            byte n = byte.Parse(Console.ReadLine());
            short sumLitters = 0;
            for (int i = 0; i < n; i++)
            {
                short quantitiesWater = short.Parse(Console.ReadLine());
                //sumLitters += waterTankCapacity;
                //if (sumLitters > waterTankCapacity)
                //{
                //    Console.WriteLine("Insufficient capacity!");
                //    sumLitters -= waterTankCapacity;
                //    continue;
                //}
                if ((sumLitters + quantitiesWater) <= waterTankCapacity)
                {
                    sumLitters += quantitiesWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(sumLitters);
        }
    }
}
