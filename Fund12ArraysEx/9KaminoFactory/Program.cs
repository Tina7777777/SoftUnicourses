using System;
using System.Linq;

namespace _9KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int rotation = n % array.Length;
            for (int i = 0; i < rotation; i++)
            {
                int firstNumber = array[0];
                for (int j = 0; j < array.Length-1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstNumber;
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }
}
