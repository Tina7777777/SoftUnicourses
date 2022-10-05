using System;
using System.Collections.Generic;

namespace Proba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("one", 1);
            dictionary.Add("ten", 10);
           
            Console.WriteLine(dictionary["one"]);
        }
    }
}
