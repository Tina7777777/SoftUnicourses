using System;
using System.Collections.Generic;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            string input = Console.ReadLine();

            while (input!="buy")
            {
                string[] inputInfo = input.Split();

                string name = inputInfo[0];
                double price = double.Parse(inputInfo[1]);
                int quantity = int.Parse(inputInfo[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new double[2]);
                }

                double previosQuantity = products[name][1];
                double[] priceQuantity = new double[] { price, previosQuantity+ quantity };
                products[name] = priceQuantity;
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
