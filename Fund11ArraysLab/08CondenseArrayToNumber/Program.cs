using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = num.Length;


            for (int j = 0; j < n - 1; j++)
            {
                int[] condensed = new int[num.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = num[i] + num[i + 1];
                }
                num = condensed;
            }
            Console.WriteLine(String.Join(" ", num));

        }
    }
}
