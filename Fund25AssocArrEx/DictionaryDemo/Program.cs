using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> engBgDict = new Dictionary<string, string>();

            engBgDict["Cat"] = "Котка";

            if (!engBgDict.ContainsKey("Dog"))
            {
            engBgDict.Add("Dog", "Куче");
            }

            Console.WriteLine(engBgDict["Cat"]);

            engBgDict.Remove("Dog");
            Console.WriteLine(engBgDict.Count);

            foreach (var item in engBgDict)
            {
                Console.WriteLine(item);
                Console.WriteLine($"{item.Key}->{item.Value}");
            }

            foreach (var (enKey, bgValue) in engBgDict)
            {
                Console.WriteLine($"{enKey}->{bgValue}");
            }
        }
    }
}
