using System;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Kristina Stojkova Dimanova ";
            string surname = name.Substring(9,8);
            int indexLastname = name.LastIndexOf("Dimanova");
            string lastName = name.Substring(indexLastname);
            Console.WriteLine(surname);
            Console.WriteLine(lastName);

        }
    }
}
