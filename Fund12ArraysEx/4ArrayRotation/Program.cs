using System;
using System.Linq;

namespace _4ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotation = int.Parse(Console.ReadLine());
            numberRotation %= array.Length;

            for (int i = 0; i < numberRotation; i++)
            {
            int firstNum = array[0];
                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
