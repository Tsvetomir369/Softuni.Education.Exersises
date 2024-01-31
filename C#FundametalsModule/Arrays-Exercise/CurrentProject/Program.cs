using System;
using System.Linq;

namespace CurrentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1!0!0!1!1

            int n = int.Parse(Console.ReadLine());

            int bestLength = 1;
            int bestStartIndex= 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounter = 0;
            string input = Console.ReadLine();
            while (input != "Clone them!")
            {
                int[] currentSequences = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int bestCurrentLength = 1;
                int bestCurrentStartIndex = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < currentSequences.Length - 1; i++)
                {
                    if (currentSequences[i] == currentSequences[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        bestCurrentStartIndex = i;
                    }

                    currentSequenceSum += currentSequences[i];
                }
                currentSequenceSum += currentSequences[n - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = bestCurrentStartIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequences.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (bestCurrentStartIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = bestCurrentStartIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequences.ToArray();
                    }
                    else if (bestCurrentStartIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = bestCurrentStartIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequences.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));

        }
    }
}
