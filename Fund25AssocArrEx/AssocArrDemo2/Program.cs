using System;
using System.Collections.Generic;

namespace AssocArrDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            Dictionary<string, int> test = new Dictionary<string, int>();

            var productKey = products["Beer"];
            //double[] productKey = products["Beer"];

            var testKey = test["test"];
        }
    }
}
