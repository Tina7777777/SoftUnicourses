using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputElements = input.Split();
                string command = inputElements[0];
                int element = int.Parse(inputElements[1]);
                if (command == "Delete")
                {

                    //  while (numbers.Remove(element))
                    // {

                    // }
                    numbers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int position = int.Parse(inputElements[2]);
                    numbers.Insert(position, element);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}

