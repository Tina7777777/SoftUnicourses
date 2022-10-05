using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int searchedNumber = int.Parse(Console.ReadLine());
            int count = 0;

            while (number>0)
            {
                int leftover = number % 2;
                if (leftover==searchedNumber)
                {
                    count++;
                }
                number/= 2;
            }
            Console.WriteLine(count);
        }
    }
}
