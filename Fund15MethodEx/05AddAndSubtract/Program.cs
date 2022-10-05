using System;

namespace _05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int seconNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int sum=Sum(firstNumber, seconNumber);
            int result =Subtract(sum, thirdNumber);
            Console.WriteLine(result);
        }

        private static int Subtract(int sum, int thirdNumber)
        {
            int result = sum - thirdNumber;
            return result;
        }

        private static int Sum(int firstNumber, int seconNumber)
        {
            int result = firstNumber + seconNumber;
            return result;
        }
    }
}
