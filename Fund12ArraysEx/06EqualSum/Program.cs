using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noNum = true;
            for (int i = 0; i < input.Length; i++)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += input[j];
                }
                
                for (int k = i+1; k < input.Length; k++)
                {
                    sum2 += input[k];
                }
                if (sum1 == sum2)
                {
                    noNum = false;
                    Console.WriteLine(i);
                    
                }               
            }
            if (noNum)
            {
                Console.WriteLine("no");
            }            
        }
    }
}
