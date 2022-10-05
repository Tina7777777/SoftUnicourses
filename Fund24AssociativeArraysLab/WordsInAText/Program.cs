using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsInAText
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> numbers = new Dictionary<string, int>();

            var numbersASArray = Console.ReadLine().Split();
            //string[] numbersAsArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < numbersASArray.Length; i++)
            {
                if (!numbers.ContainsKey(numbersASArray[i]))
                {
                    numbers.Add(numbersASArray[i], 0);
                }
                numbers[numbersASArray[i]]++;
            }
            numbers = numbers.OrderByDescending(p => p.Value)
                .ThenByDescending(p=>p.Key)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
