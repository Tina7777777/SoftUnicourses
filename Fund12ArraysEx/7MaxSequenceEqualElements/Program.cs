using System;
using System.Linq;

namespace _7MaxSequenceEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int startIndex = 1;
            int maxSequence = 1;
            int bestStartindex = 0;

            for (int i = 1; i < array.Length ; i++)
            {

                if (array[i] == array[i - 1])
                {
                    count++;
                    startIndex = i - count + 1;

                }
                else
                {
                    count = 1;
                    startIndex = 0;
                }
                if (maxSequence < count)
                {
                    maxSequence = count;
                    bestStartindex = startIndex;
                }
            }

            for (int k = bestStartindex; k < bestStartindex + maxSequence; k++)
            {
                Console.Write(array[k] + " ");
            }
        }
    }
}
