using System;

namespace _03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            // int courses = peopleNumber / capacity;
            //if (peopleNumber%capacity!=0)
            //{
            //    courses++;
            // }
            // Console.WriteLine(courses);
            Console.WriteLine(Math.Ceiling((double)peopleNumber/capacity));
        }
    }
}
