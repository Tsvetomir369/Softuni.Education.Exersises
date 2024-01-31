using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] operations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (operations[0].ToUpper() != "END")
            {
                switch (operations[0].ToUpper())
                {
                    case "ADD":
                        int addNum = int.Parse(operations[1]);
                        numbers.Add(addNum);
                        break;
                    case "INSERT":
                        int insertNum = int.Parse(operations[1]);
                        int index = int.Parse(operations[2]);

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.Insert(index, insertNum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "REMOVE":
                        int removeIndex = int.Parse(operations[1]);

                        if (removeIndex >= 0 && removeIndex < numbers.Count)
                        {
                            numbers.RemoveAt(removeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "SHIFT":
                        int count = int.Parse(operations[2]);

                        if (operations[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Add(firstNum);
                                numbers.RemoveAt(0);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Insert(0, lastNum);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }

                        break;
                    default:
                        break;
                }


                operations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
