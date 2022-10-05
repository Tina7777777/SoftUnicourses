using System;

namespace _11.ТrialАndЕrror
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
