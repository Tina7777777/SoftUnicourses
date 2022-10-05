using System;

namespace _1Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int totalPeople = 0;
            for (int i = 0; i < n; i++)
            {
                // int people = int.Parse(Console.ReadLine());
                // train[i] = people;
                train[i] = int.Parse(Console.ReadLine());
                totalPeople += train[i];
            }
            Console.WriteLine(string.Join(" ",train));
            Console.WriteLine(totalPeople);
            
        }
    }
}
