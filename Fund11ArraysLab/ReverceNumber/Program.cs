﻿using System;
using System.Linq;

namespace ReverceNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().Reverse().ToArray();
            Console.WriteLine(string.Join(" ",strings));
        }
    }
}
