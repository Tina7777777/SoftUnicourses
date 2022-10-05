using System;
using System.Text.RegularExpressions;

namespace _003MonthlyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //(?<userRound>U\$)(?<username>[A-Z][a-z]{2,})\k<userRound>(?<passwordRound>P@\$)[A-z]{5,}[0-9]+\k<passwordRound>
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Regex registration = new Regex(@"(?<userRound>U\$)(?<username>[A-Z][a-z]{2,})\k<userRound>(?<passwordRound>P@\$)(?<password>[A-z]{5,}[0-9]+)\k<passwordRound>");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = registration.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["username"].Value}, Password: {match.Groups["password"].Value}");
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                    
                }
            }
            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
