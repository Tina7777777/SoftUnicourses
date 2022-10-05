using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbaLambda3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 2, 7, 8, 3, 9 };
            list =list.Where((n, index) => index%2==0).ToList();
            Console.WriteLine(String.Join(", ",list));
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());
        }
    }
}
