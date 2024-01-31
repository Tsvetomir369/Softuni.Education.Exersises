using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read DNA length an integer
            //Read sequences until we receive "Clone them!"
            //Find sequence with the longest subsequence of ones.
            //If there are several sequences with same
            //length of subsequence of ones,
            //print the one with the leftmost starting index,
            //if there are several sequences with
            //same length and starting index,
            //select the sequence with the greater sum of its elements.

            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounter = 0;

            while (command != "Clone them!")
            {
                int[] currentSequences = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;
                //1!0!1!1!0

                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
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
                        startIndex = i;
                    }
                    currentSequenceSum += currentSequences[i];
                }
                currentSequenceSum += currentSequences[n - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequences.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequences.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequences.ToArray();
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
