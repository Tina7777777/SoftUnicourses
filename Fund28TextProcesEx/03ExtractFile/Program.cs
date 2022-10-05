using System;

namespace _03ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            int lastIndesxOfLeftPipe = fullPath.LastIndexOf('\\');
            string fileNameWithExtention = fullPath.Substring(lastIndesxOfLeftPipe + 1);
            int lastPoint = fileNameWithExtention.LastIndexOf('.');
            string file = fileNameWithExtention.Substring(0, lastPoint);
            string extention = fileNameWithExtention.Substring(lastPoint + 1);

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
