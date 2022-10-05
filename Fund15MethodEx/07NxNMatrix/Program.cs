using System;

namespace _07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintMatrix(N);
        }

        private static void PrintMatrix(int n)
        {

            for (int i =1 ; i <=n; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
