using System;
using System.Text.RegularExpressions;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");
            Match match = nameRegex.Match(input);
            Console.WriteLine($"{match.Value} {match.Success} {match.Index} {match.NextMatch().Value}");
            Console.WriteLine($"First Name {match.Groups["firstName"].Value}");
            Console.WriteLine($"Last Name {match.Groups["lastName"].Value}");

        }
    }
}
