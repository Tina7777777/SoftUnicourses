using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] text = Console.ReadLine().Split();
            //int[] numbers = new int[text.Length];
            //int sum = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    numbers[i] = int.Parse(text[i]);
            //    if (numbers[i]%2==0)
            //    {
            //        sum += numbers[i];
            //    }
            //}
            //Console.WriteLine(sum);

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum%2==0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
