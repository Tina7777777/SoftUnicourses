using System;
using System.Collections.Generic;
using System.Linq;

namespace _08AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();
            string command = Console.ReadLine();
            while (command!="3:1")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int startIndex = int.Parse(commandArgs[1]);
                int endIndex = int.Parse(commandArgs[2]);

                if (action=="merge")
                {
                    string mergedString = string.Empty;
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        if (i<0 || i>=names.Count)
                        {
                            continue;
                        }
                        mergedString += names[i];
                        names.RemoveAt(i);
                    }
                    names.Insert(startIndex, mergedString);
                }


                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
