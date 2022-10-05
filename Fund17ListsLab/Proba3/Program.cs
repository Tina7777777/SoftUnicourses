using System;
using System.Collections.Generic;
using System.Linq;

namespace Proba3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string toFind = Console.ReadLine();
            int index = 0;
            while (index != -1)
            {
                index = list.IndexOf(toFind, index+1);
                if (index==-1)
                {
                    break;
                }
                Console.WriteLine($"{toFind} found at {index}");
            }
            Console.WriteLine(list.IndexOf(toFind,3));
            Console.WriteLine(list.Count);
            list.Sort();
            Console.WriteLine(String.Join(",", list));
        }
    }
}
