using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCnt = int.Parse(Console.ReadLine());

            List<string> listGuests = new List<string>();

            for (int i = 0; i < commandsCnt; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[0];

                if (command.Length == 3)
                {
                    if (listGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        listGuests.Add(name);
                    }
                }
                else
                {
                    if (listGuests.Contains(name))
                    {
                        listGuests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, listGuests));
            //foreach (var name in listGuests)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
