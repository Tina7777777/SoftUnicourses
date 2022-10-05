using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int countIteration = numbers.Count / 2;
            for (int i = 0; i < countIteration; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
