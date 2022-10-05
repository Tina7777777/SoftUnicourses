using System;
using System.Text.RegularExpressions;

namespace _02Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                Regex mesage = new Regex(@"([*@]){1}[A-Z]{1}[a-z]{2,}\1[:][\s](?<gr1>[\[][A-z][\]][|])(?<gr2>[\[][A-z][\]][|])(?<gr3>[\[][A-z][\]][|])");
                MatchCollection code = mesage.Matches(input);

                foreach (Match codes in code)
                {
                    Console.WriteLine(codes.Value);

                }
            }
        }
    }
}
