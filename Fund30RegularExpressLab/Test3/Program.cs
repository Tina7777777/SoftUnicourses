using System;
using System.Text.RegularExpressions;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"John Smith Dimitrichko Pesho Petrov gosho goshkata";
            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");
            MatchCollection fullNames = nameRegex.Matches(input);

            foreach (Match fullName in fullNames)
            {
                Console.WriteLine(fullName.Value);
                Console.WriteLine($"First name -> {fullName.Groups["firstName"]}");
                Console.WriteLine($"Last name -> {fullName.Groups["lastName"]}");
                Console.WriteLine("\n");
            }
        }
    }
}
