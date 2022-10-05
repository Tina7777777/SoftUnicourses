using System;
using System.Text;

namespace _06ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    result.Append(input[i]);
                }                
            }
            
                result.Append(input[input.Length - 1]);
            
            Console.WriteLine(result);
        }
    }
}
