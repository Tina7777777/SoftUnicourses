using System;
using System.Collections.Generic;

namespace _01CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Dictionary<char, int> numberChars = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                for (int j = 0; j < word.Length; j++)
                {

                    if (!numberChars.ContainsKey(word[j]))
                    {
                        numberChars.Add(word[j], 0);
                    }
                    numberChars[word[j]]++;
                }
            }
            foreach (var item in numberChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
