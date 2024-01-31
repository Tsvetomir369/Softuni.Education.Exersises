using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntFloors = int.Parse(Console.ReadLine());
            int cntRooms = int.Parse(Console.ReadLine());

            for (int i = cntFloors; i >= 1; i--)
            {
                for (int k = 0; k < cntRooms; k++)
                {
                    if (i == cntFloors)
                    {
                        Console.Write($"L{i}{k} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{k} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{k} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
