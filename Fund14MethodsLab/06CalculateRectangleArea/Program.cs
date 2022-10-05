using System;

namespace _06CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = CalculateArea(a, b);
            Console.WriteLine(c);
        }
        private static double CalculateArea(double width, double length)
        {
            double area = width * length;
            return area;
        }
    }
}
