using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int count = 0;

            string input = Console.ReadLine();
            while (input?.ToUpper() != "END")
            {
                int index = int.Parse(input);
                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                int shootedTargetValue = targets[index];
                //targets[index] -= shootedTargetValue;
                targets[index] = -1;
                count++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > shootedTargetValue)
                    {
                        targets[i] -= shootedTargetValue;
                    }
                    else
                    {
                        targets[i] += shootedTargetValue;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(' ', targets)}");
        }
    }
}
