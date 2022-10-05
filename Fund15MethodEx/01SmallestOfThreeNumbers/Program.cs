using System;

namespace _01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int seconNumber = int.Parse(Console.ReadLine());
            int thirdNumber= int.Parse(Console.ReadLine());

            int result =PrintSmallestNumber(firstNumber, seconNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int PrintSmallestNumber(int a, int b ,int c)
        {
            int smallestNumbber = a;
            if (a>b)
            {
                smallestNumbber = b;
            }
            
            if (smallestNumbber>c)
            {
                smallestNumbber = c;
            }
           
            return smallestNumbber;
        }
    }
}
