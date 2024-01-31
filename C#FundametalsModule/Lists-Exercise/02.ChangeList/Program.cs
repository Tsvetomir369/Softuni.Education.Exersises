using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commands[0].ToUpper() != "END")
            {

                switch (commands[0].ToUpper())
                {                    
                    case "DELETE":                       
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (int.Parse(commands[1]) == numbers[i])
                            {
                                numbers.Remove(int.Parse(commands[1]));
                                i--;
                            }  
                        }
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                    default:
                        break;
                }


                commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
