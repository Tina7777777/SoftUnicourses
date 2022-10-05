using System;
using System.Linq;

namespace _07MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    length += 1;
                }
                else
                {
                    length = 1;
                    start = i;
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;
                }
            }
            if (maxLength == 1)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                for (int i = bestStart; i < bestStart + maxLength; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
