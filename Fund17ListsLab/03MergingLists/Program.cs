using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstColection = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondColection = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

            List<int> result = new List<int>();
            int maxCount = Math.Max(firstColection.Count, secondColection.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if (i<firstColection.Count)
                {
                    result.Add(firstColection[i]);
                }
                if (i<secondColection.Count)
                {
                    result.Add(secondColection[i]);
                }

            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
