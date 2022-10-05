using System;
using System.Text;

namespace _01Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Complete")
            {
                if (command== "Make Upper" )
                {
                    email = email.ToUpper();
                    Console.WriteLine(email);
                }
                if (command == "Make Lower")
                {
                    email = email.ToLower();
                    Console.WriteLine(email);
                }
                if (command.Contains("GetDomain"))
                {
                    string[] splitted = command.Split();
                    string get = splitted[0];
                    int count = int.Parse(splitted[1]);

                    string domain = email.Substring(email.Length-count,count);
                    Console.WriteLine(domain);
                }
                if (command== "GetUsername")
                {
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        int index = 0;
                        for (int i = 0; i < email.Length; i++)
                        {
                            if (email[i]=='@')
                            {
                                 index = i;
                            }
                        }
                        string username=email.Substring(0, index);
                        Console.WriteLine(username);
                    }
                }
                if (command.Contains("Replace"))
                {
                    string[] splitted = command.Split();
                    string replace = splitted[0];
                    string letter = splitted[1];

                    string result = email.Replace(letter, "-");
                    Console.WriteLine(result);
                }
                if (command== "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        Console.Write((int)email[i]+" ");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
