using System;
using System.Linq;

namespace _05WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] words = Console.ReadLine().Split();
            words = words.Where(w => w.Length % 2 == 0).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine,words));
        }
    }
}
