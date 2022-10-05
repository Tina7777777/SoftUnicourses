using System;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitEmploy = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());
            int concurentCountBiscuits = int.Parse(Console.ReadLine());
            int dayBiscuits = biscuitEmploy * employees;
            double thirdDayBiscuits = Math.Floor(dayBiscuits * 0.75);
            double monthlyBiscuits = (20 * dayBiscuits) + (10 * thirdDayBiscuits);
            double diference = 0;
            double percentDiference = 0;
            if (monthlyBiscuits>concurentCountBiscuits)
            {
                diference = monthlyBiscuits - concurentCountBiscuits;
                percentDiference = diference / concurentCountBiscuits * 100;
                Console.WriteLine($"You have produced {monthlyBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {percentDiference:f2} percent more biscuits.");
            }
            else
            {
                diference = concurentCountBiscuits - monthlyBiscuits;
                percentDiference = diference / concurentCountBiscuits * 100;
                Console.WriteLine($"You have produced {monthlyBiscuits} biscuits for the past month.");
                Console.WriteLine($"You produce {percentDiference:f2} percent less biscuits.");
            }

            // You have produced 17160 biscuits for the past month.
            //You produce 7.25 percent more biscuits.
            //You produce 17.50 percent less biscuits.
        }
    }
}
