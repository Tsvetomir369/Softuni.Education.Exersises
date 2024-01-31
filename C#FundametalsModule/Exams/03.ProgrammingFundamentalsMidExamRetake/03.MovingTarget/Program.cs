using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()?.ToUpper()) != "END")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                int index = int.Parse(tokens[1]);
                int value = int.Parse(tokens[2]);
                bool notExists = (index < 0 || index >= targets.Count);
                bool invalidRange = (index - value < 0 || index + value > targets.Count);

                if (notExists)
                {
                    if (command == "SHOOT")
                    {
                        continue;
                    }
                    else if (command == "ADD")
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }

                }
                else if (command == "STRIKE")
                {
                    if (notExists || invalidRange)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                };

                switch (command)
                {
                    case "SHOOT":
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;
                    case "ADD":
                        targets.Insert(index, value);
                        break;
                    case "STRIKE":
                        for (int i = index - value; i <= index + value; i++)
                        {
                            targets.RemoveAt(index - value);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
