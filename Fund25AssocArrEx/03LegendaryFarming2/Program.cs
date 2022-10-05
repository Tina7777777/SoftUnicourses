using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>
            {
                {"shards",0 },
                {"fragments",0 },
                {"motes",0 }
            };
            Dictionary<string, int> junks = new Dictionary<string, int>();
            string element = string.Empty;
            bool isFound = false;
            while (!isFound)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int value = int.Parse(input[i]);
                     element = input[i + 1].ToLower();
                    //Shards, Fragments and Motes
                    if (element == "shards" ||
                        element == "fragments" ||
                        element == "motes")
                    {
                        items[element] += value;
                    }
                    else
                    {
                        if (!junks.ContainsKey(element))
                        {
                            junks.Add(element, 0);
                        }

                        junks[element] += value;
                    }

                    if (items.Values.Any(x => x >= 250))
                    {
                        items[element] -= 250;
                        isFound = true;
                        break;
                    }
                }
            }

            if (element == "motes")
            {

                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (element == "fragments")
            {

                Console.WriteLine("Valanyr obtained!");
            }
            else if (element == "shards")
            {

                Console.WriteLine("Shadowmourne obtained!");
            }

            foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var junk in junks.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
