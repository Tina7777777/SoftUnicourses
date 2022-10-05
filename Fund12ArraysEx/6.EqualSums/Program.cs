using System;
using System.Linq;

namespace _6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool noSum = true;
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = i+1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    noSum = false;
                }                
            }
            if (noSum)
            {
                Console.WriteLine("no");
            }            
        }
    }
}
