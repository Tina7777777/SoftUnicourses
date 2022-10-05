using System;
using System.Collections.Generic;
using System.Linq;

namespace proba2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            if (list.Contains("pesho")) 
            {
                Console.WriteLine("Pesho go ima");
            }
            Console.WriteLine(list.Contains("pesho"));
            Console.WriteLine( list.IndexOf("pesho"));
        }
    }
}
