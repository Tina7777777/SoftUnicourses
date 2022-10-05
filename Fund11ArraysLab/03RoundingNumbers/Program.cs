﻿using System;
using System.Linq;

namespace _03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]==0)
            //    {
            //        array[i] = 0;
            //    }
            //    int roundedNumber = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{array[i]} => {roundedNumber}");
            //}

            string[] numbers = Console.ReadLine().Split();
            double[] array = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = double.Parse(numbers[i]);
                if (array[i]==0)
                {
                    array[i] = 0;
                }
                int roundedNumber = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {roundedNumber}");
            }

        }
    }
}
