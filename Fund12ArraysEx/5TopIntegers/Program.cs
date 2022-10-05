using System;
using System.Linq;

namespace _5TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                    
                    bool topIntiger = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]<=array[j])
                    {
                        topIntiger = false;
                        break;
                    }
                    else
                    {
                        topIntiger = true; 
                    }
                }
                if (topIntiger)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
