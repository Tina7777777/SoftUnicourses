using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split("|");
            List<int> list = new List<int>();
            List<int> totalList = new List<int>();
            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                list = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                //list.Sort();
                totalList.AddRange(list);
            }
            Console.WriteLine(String.Join(" ",totalList));
        }
    }
}
