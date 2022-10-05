using System;
using System.Text;

namespace StringBuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("Kaloqn risuva mnogo hubavo!");
            Console.WriteLine(text);
            text = text.Clear();
            Console.WriteLine($"nov{text}");
            

        }
    }
}
