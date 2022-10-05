using System;
using System.Numerics;

namespace BigFactorialWithClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(n);
            Console.WriteLine(calculator.Calculate());
        }
    }
   
}
