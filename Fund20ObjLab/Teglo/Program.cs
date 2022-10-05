using System;

namespace Teglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglo dnes = new Teglo();
            Console.WriteLine("Килограми:");
            dnes.kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("Вода в тялото в Килограми:");
            dnes.water = double.Parse(Console.ReadLine());
            Console.WriteLine("Протеини в тялото в Килограми:");
            dnes.protein = double.Parse(Console.ReadLine());
            Console.WriteLine("Мазнини в тялото в Килограми:");
            dnes.fat = double.Parse(Console.ReadLine());
            PrintPercentWter(dnes);
            PrintPercentProtein(dnes);
            PrintPercentFat(dnes);
        }
        static void PrintPercentWter(Teglo utre)
        {
            double percentWter = (utre.water * 100) / utre.kilo;           
            Console.WriteLine($"Процент вода в тялото:{percentWter}");
        }
        static void PrintPercentProtein(Teglo utre)
        {
            double percentProtein = (utre.protein * 100) / utre.kilo;
            Console.WriteLine($"Процент протеин в тялото:{percentProtein}");
        }
        static void PrintPercentFat(Teglo utre)
        {
            double percentFat = (utre.fat * 100) / utre.kilo;
            Console.WriteLine($"Процент мазнини в тялото:{percentFat}");
        }
    }
    class Teglo
    {
        
        public double kilo;
        public double water;
        public double protein;
        public double fat;
        public double bones;
    }
}
