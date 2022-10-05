using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            var numbersASArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //double[] numbersAsArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < numbersASArray.Length; i++)
            {
                if (!numbers.ContainsKey(numbersASArray[i]))
                {
                    numbers.Add(numbersASArray[i], 0);
                }
                numbers[numbersASArray[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
