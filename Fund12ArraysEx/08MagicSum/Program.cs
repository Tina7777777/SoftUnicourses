using System;
using System.Linq;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    sum = input[i] + input[j];
                    if (sum==num)
                    {
                        Console.WriteLine(input[i] + " " +input[j]);
                    }
                }
            }
        }
    }
}
