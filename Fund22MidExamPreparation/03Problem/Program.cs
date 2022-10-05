using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            string input = Console.ReadLine();
            List<string> myCard = new List<string>();
            while (input != "Ready")
            {
                string[] splitted = input.Split(" ");
                string command = splitted[0];
                string cardName = splitted[1];
                if (command == "Add")
                {
                    if (cards.Contains(cardName))
                    {
                        myCard.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                if (command == "Insert")
                {
                    string number = splitted[2];
                    int index = int.Parse(number);

                    if (index > myCard.Count - 1 && index < 0 || !cards.Contains(cardName))
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        myCard.Insert(index, cardName);
                    }

                }
                if (command == "Remove")
                {
                    if (!myCard.Contains(cardName))
                    {
                        Console.WriteLine("Card not found.");
                    }
                    else
                    {
                        myCard.Remove(cardName);
                    }
                }
                if (command == "Swap")
                {
                    string temp = "";
                    string cardName2 = splitted[2];
                    int index = myCard.IndexOf(cardName);
                    int index2 = myCard.IndexOf(cardName2);
                    myCard.RemoveAt(index);
                    myCard.Insert(index, temp);
                    myCard.RemoveAt(index2);
                    myCard.Insert(index2, cardName);
                    myCard.RemoveAt(index);
                    myCard.Insert(index, cardName2);
                }
                if (command == "Shuffle")
                {
                    myCard.Reverse();
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",myCard));
        }
    }
}
