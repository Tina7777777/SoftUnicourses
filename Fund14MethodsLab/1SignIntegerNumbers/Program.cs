using System;

namespace _1SignIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            IsPozitiveOrNegative(num);
        }

        private static void IsPozitiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
