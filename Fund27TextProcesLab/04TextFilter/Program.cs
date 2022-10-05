using System;

namespace _04TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] censuredWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in censuredWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
