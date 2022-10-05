using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] splitted = input.Split(" ");
                string command = splitted[0];
                string item = splitted[1];
                
                if (command == "Urgent")
                {
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                if (command == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                }
                if (command == "Correct")
                {
                    string newItem = splitted[2];
                    if (shoppingList.Contains(item))
                    {
                        int index = shoppingList.IndexOf(item);
                        shoppingList.RemoveAt(index);
                        shoppingList.Insert(index, newItem);
                    }
                }
                if (command == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
