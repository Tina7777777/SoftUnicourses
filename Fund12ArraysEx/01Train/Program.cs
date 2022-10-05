using System;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;
            for (int i = 0; i < train.Length; i++)
            {
                train[i]= int.Parse(Console.ReadLine());
                sum += train[i];                
            }
            //for (int j = 0; j < train.Length; j++)
            //{
            //    Console.Write(train[j]+" ");
            //}
            // Console.WriteLine();
            Console.WriteLine(String.Join(" ",train));           
            Console.WriteLine(sum);
        }
    }
}
