using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            string input = Console.ReadLine();
            int count = 1;
            string currentItem = string.Empty;

            while (input!="stop")
            {
                if (count%2!=0)
                {
                    if (!items.ContainsKey(input))
                    {
                        items.Add(input, 0);
                    }
                        currentItem = input;
                }
                else
                {
                    int value = int.Parse(input);
                    items[currentItem]+= value;
                }

                input = Console.ReadLine();
                count++;
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
