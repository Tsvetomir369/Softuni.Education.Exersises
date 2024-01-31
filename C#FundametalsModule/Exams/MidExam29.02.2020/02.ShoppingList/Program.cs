using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commands = cmdArgs[0];
                string item = cmdArgs[1];

                switch (commands)
                {
                    case "Urgent":
                        if (!groceries.Contains(item))
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                        }
                        break;
                    case "Correct":
                        string newItem = cmdArgs[2];
                        if (groceries.Contains(item))
                        {
                            int index = groceries.FindIndex(x => x == item);
                            groceries.RemoveAt(index);
                            groceries.Insert(index, newItem);
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.Remove(item);
                            groceries.Add(item);
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
