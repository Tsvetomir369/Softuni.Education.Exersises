using System;
using System.Linq;

namespace _05.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCnt = int.Parse(Console.ReadLine());
            int[] currentState = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool noMorePeople = false;
            int maxCapacity = 4;

            for (int i = 0; i < currentState.Length; i++)
            {
                if (currentState[i] == maxCapacity)
                {
                    continue;
                }
                else
                {
                    while (currentState[i] < maxCapacity)
                    {
                        if (peopleCnt == 0)
                        {
                            noMorePeople = true;
                            break;
                        }
                        currentState[i] += 1;
                        peopleCnt--;
                    }
                }

            }

            if (noMorePeople)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', currentState));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {peopleCnt} people in a queue!");
                Console.WriteLine(string.Join(' ', currentState));
            }
        }
    }
}
