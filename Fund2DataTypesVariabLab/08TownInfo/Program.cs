﻿using System;

namespace _08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Town {town name} has population of {population} and area {area} square km
            string townName = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
