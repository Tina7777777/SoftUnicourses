using System;

namespace _03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //add, multiply, subtract, divide(добавяне, умножаване, изваждане, разделяне)
            string calculation = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (calculation == "add")
            {
                Add(a, b);
            }
            else if (calculation == "multiply")
            {
                Multiply(a, b);
            }
            else if (calculation == "subtract")
            {
                Subtract(a, b);
            }
            else if (calculation == "divide")
            {
                Divide(a, b);
            }

        }
        private static void Subtract(double firstNum, double secondNum)
        {
            double result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        private static void Multiply(double firstNum, double secondNum)
        {
            double result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        private static void Add(double firstNum, double secondNum)
        {
            double result = firstNum + secondNum;
            Console.WriteLine(result);
        }

        private static void Divide(double firstNum, double secondNum)
        {
            double result = firstNum / secondNum;
            Console.WriteLine(result);
        }
    }
}
