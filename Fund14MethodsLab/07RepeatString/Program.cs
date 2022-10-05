using System;

namespace _07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(name, n);
            Console.WriteLine(result);
        }

        private static string RepeatString(string name, int n)
        {
            string result = " ";
            for (int i = 0; i < n; i++)
            {
                result += name; 
            }
            return result;
        }
    }
}
