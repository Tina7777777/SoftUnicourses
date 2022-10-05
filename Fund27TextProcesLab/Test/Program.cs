using System;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello, ");
            sb.Append("John! ");
            sb.Append("I send you an email.");

            StringBuilder text = new StringBuilder("pesho");
            text.Append(" test");

            //text+="some string\n"
            text.AppendLine(" some string");
            text.Append("on new line");

            Console.WriteLine(text);

            string dots = new string('.', 155);
            Console.WriteLine(dots);

            StringBuilder frase = new StringBuilder();
            frase.Append("Hello Peter, how are you?");
            Console.WriteLine(frase[1]);
            Console.WriteLine(frase.Length);


        }
    }
}
