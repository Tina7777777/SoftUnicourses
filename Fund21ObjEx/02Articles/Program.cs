using System;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split(": ");
                string commandName = splitted[0];
                string commandValue = splitted[1];
                if (commandName== "Edit")
                {
                    article.Edit(commandValue);
                }
                if (commandName == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandValue);
                }
                if (commandName == "Rename")
                {
                    article.Rename(commandValue);
                }
            }

            Console.WriteLine(article);
        }
    }

    
}
