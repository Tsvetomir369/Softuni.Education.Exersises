using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int passengers = int.Parse(command[1]);
                    trainWagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(command[0]);

                    for (int i = 0; i < trainWagons.Count; i++)
                    {
                        if (trainWagons[i] + passengers <= maxCapacity)
                        {
                            trainWagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(" ", trainWagons));
        }
    }
}
