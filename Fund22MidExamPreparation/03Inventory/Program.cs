using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();
            while (command!= "Craft!")
            {
                var splitted = command.Split(" - ");
                string commandName = splitted[0];
                string commandValue = splitted[1];
                if (commandName =="Collect")
                {
                    if (!items.Contains(commandValue))
                    {
                    items.Add(commandValue);
                    }
                    //bool isFound = false;
                    //for (int i = 0; i < items.Count; i++)
                    //{
                    //    isFound = true;
                    //    break;
                    //}

                    //if (!isFound)
                    //{
                    //    items.Add(commandValue);
                    //}
                }
                if (commandName == "Drop")
                {
                    items.Remove(commandValue);
                    //for (int i = 0; i < items.Count; i++)
                    //{
                    //    if (items[i]==commandValue)
                    //    {
                    //        items.RemoveAt(i);
                    //    }
                    //}
                }
                if (commandName == "Renew")
                {
                    bool isDeleted= items.Remove(commandValue);
                    if (isDeleted)
                    {
                        items.Add(commandValue);
                    }
                    //if (items.Remove(commandValue))
                    //{
                    //    items.Add(commandValue);
                    //}
                }
                if (commandName == "Combine Items")
                {
                    string[] splittedValue = commandValue.Split(":");
                    string oldItem = splittedValue[0];
                    string newItem = splittedValue[1];

                    int index = items.IndexOf(oldItem);
                    if (index>=0)
                    {
                        items.Insert(index + 1, newItem);
                    }

                    
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", items));
        }
    }
}
