using System;

namespace _12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num%2!=0)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                               
                num = int.Parse(Console.ReadLine());
            }
                    Console.WriteLine($"The number is: {Math.Abs(num)}");               
        }
    }
}
