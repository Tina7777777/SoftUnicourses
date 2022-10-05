using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = GetMinNumber(a, b, c);
            Console.WriteLine(result);
        }

         static int GetMinNumber(int a, int b, int c)
        {
            int minNumber = b;
            if (a<b)
            {
                minNumber = a;
            }
           
            if (c<minNumber)
            {
                minNumber = c;
            }
            return minNumber;
        }
    }
}
