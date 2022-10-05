using System;

namespace _09SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            //int addNum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(addNum);
            //    sum += addNum;
            //    addNum += 2;
            //}
            //Console.WriteLine($"Sum: {sum}");
            for (int i = 1; i <=2*n; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
