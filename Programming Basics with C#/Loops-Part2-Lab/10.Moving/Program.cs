using System;

namespace _10.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalArea = width * length * height;
            int boxesArea = 0;

            string command = Console.ReadLine();
            while (command != "Done")
            {
                int boxes = int.Parse(command);
                boxesArea += boxes;
                if (totalArea <= boxesArea)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            int diff = Math.Abs(totalArea - boxesArea);
            if (totalArea <= boxesArea)
            {
                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{diff} Cubic meters left.");
            }
        }
    }
}
