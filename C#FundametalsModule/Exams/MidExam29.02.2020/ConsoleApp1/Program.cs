using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int jumpedLength = 0;
            string input;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = input.Split(' ');
                int length = int.Parse(cmdArgs[1]);
                jumpedLength += length;

                if (jumpedLength >= 0 && jumpedLength < neighborhood.Length)
                {
                    neighborhood[jumpedLength] -= 2;
                }
                else
                {
                    jumpedLength = 0;
                    neighborhood[jumpedLength] -= 2;
                }

                if (neighborhood[jumpedLength] == 0)
                {
                    Console.WriteLine($"Place {jumpedLength} has Valentine's day.");
                }
                else if (neighborhood[jumpedLength] < 0)
                {
                    Console.WriteLine($"Place {jumpedLength} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {jumpedLength}.");

            int failedCnt = neighborhood.Count(x => x > 0);
            if (failedCnt == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedCnt} places.");
            }
        }
    }
}
