﻿using System;
using System.Text.RegularExpressions;

namespace _01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match item in matches)
            {
                Console.Write(item+" ");
            }
        }
    }
}
