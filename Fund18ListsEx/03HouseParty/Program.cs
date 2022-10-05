using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberComand = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            
            List<string> guests = new List<string>();
            for (int i = 0; i < numberComand; i++)
            {
                string[] input = text.Split();
                string name = input[0];
                if (input[2]=="going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (input[2]=="not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                text = Console.ReadLine();
            }

            foreach (var names in guests)
            {
                Console.WriteLine(names);
            }
        }
    }
}
