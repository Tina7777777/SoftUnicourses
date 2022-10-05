using System;
using System.Collections.Generic;
using System.Text;

namespace Proba3
{
    class Telephone
    {
        public Telephone()
        {
            Model = "Samsung";
            Weight = 150;
        }
        public Telephone(string model, string colour, int weight)
        {
            Model = model;
            Colour = colour;
            Weight = weight;
        }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Weight { get; set; }

        public void TelephonRing()
        {
            Console.WriteLine("Ding Dong...");
            Console.WriteLine($"Telephone {Colour} {Model} is ringing");
            Console.WriteLine($"It'weight is : {Weight}");
        }

        public static void TelephoneVibration()
        {
            Console.WriteLine("vibration");
        }
    }
}
