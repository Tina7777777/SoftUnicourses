using System;

namespace MedBurkanKg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Колко грама е медът в буркана:");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена на буркана с меда:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Цена на абмалажа:");
            double packagingPrice = double.Parse(Console.ReadLine());


            TotalPrice(weight, price, packagingPrice);
            
        }

        private static void TotalPrice(double weight, double price, double packagingPrice)
        {
            double netoPrice = price - packagingPrice;
            double totalPrice = (netoPrice * 1000) / weight;
            Console.WriteLine($"Цена за килограм мед:{totalPrice}");
        }

    }
}


