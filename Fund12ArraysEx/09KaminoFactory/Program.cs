using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int bestLength = 1;
            int bestStartIndexAll = 0;
            int bestSequenceSum = 0;
            int sequenceCounter = 0;
            int bestCounter = 0;
            int[] bestSequence = new int[n];
            while (input != "Clone them!")
            {
                int[] currentSeqence = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;

                int currentSequenceSum = 0;
                for (int i = 0; i < currentSeqence.Length - 1; i++)
                {
                    if (currentSeqence[i] == currentSeqence[i + 1])
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
                    currentSequenceSum += currentSeqence[i];
                }
                currentSequenceSum += currentSeqence[n - 1];
                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndexAll = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestCounter = sequenceCounter;
                    bestSequence = currentSeqence.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndexAll)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndexAll = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestCounter = sequenceCounter;
                        bestSequence = currentSeqence.ToArray();
                    }
                    else if (startIndex == bestStartIndexAll)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndexAll = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestCounter = sequenceCounter;
                            bestSequence = currentSeqence.ToArray();
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(" ", bestSequence));
        }
    }
}
