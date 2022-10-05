using System;

namespace _2PrintNumbersReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n/2; j++)
            {
                int temp = array[j];
                array[j] = array[array.Length - 1 - j];
                array[array.Length - 1 - j] = temp;
            }
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
