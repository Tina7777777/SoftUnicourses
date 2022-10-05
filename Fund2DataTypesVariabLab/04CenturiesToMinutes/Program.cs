using System;

namespace _04CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centures * 100);
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
