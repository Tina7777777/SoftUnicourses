using System;

namespace _09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();
            //Console.WriteLine(a+b+c);
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{a}{b}{c}");
            
        }
    }
}
