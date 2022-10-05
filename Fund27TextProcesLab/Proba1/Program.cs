using System;

namespace Proba1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is some text. This text is cool, correct and cool.";
            string[] words = text.Split(new string[] { " ", ", ", "!", "." },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
