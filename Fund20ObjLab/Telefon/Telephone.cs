using System;
using System.Collections.Generic;
using System.Text;

namespace Telefon
{
    class Telephone
    {
        public Telephone(string model,string colour, int weight)
        {
            Model = model;
            Colour = colour;
            Weight = weight;
        }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Weight { get; set; }
    }
}
