using System;

namespace _08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double power=MathPower(a, n);
            Console.WriteLine(power
                );
        }

        private static double MathPower(double a, int n)
        {
            double result = a;
            for (int i = 1; i < n; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
