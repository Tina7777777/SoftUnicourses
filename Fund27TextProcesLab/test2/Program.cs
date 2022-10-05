using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kristina e unicalna! Kristina e edinstwena! Kristina e nepowtorima!";
            text = text.Replace("Kristina", "Kalina");
            Console.WriteLine(text);
            string name = new string('b', 5);
            Console.WriteLine(name);
            text = text.Replace("Kalina", name);
            Console.WriteLine(text);
        }
    }
}
