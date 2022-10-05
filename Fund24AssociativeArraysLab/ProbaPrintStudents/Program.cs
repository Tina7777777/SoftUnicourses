﻿using System;
using System.Collections.Generic;

namespace ProbaPrintStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter n amount of names
            //School print all students starting with letter a,b,c,d
            Dictionary<char, List<string>> namesDict = new Dictionary<char, List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char startChar = name[0];

                if (!namesDict.ContainsKey(startChar))
                {
                    namesDict.Add(startChar, new List<string>());
                }

                //a
                namesDict[startChar].Add(name);
            }

            foreach (var item in namesDict)
            {
                //a, b, c
                Console.WriteLine($"{item.Key} -> ");
                //ALbena, Boqna, ...
                Console.WriteLine(String.Join(", ",item.Value));
            }
        }
    }
}
