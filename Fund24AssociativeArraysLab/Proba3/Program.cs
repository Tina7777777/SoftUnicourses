using System;
using System.Collections.Generic;

namespace Proba3
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> pair = new KeyValuePair<string, int>("key",55);
            Console.WriteLine(pair.Key);
            Console.WriteLine(pair.Value);

            Dictionary<string, int> humanWeights = new Dictionary<string, int>();

            humanWeights.Add("Goshko", 130);
            if (!humanWeights.ContainsKey("Goshko"))
            {
                humanWeights.Add("Goshko", 23);
            }
            else
            {
                humanWeights["Goshko"] = 23;
            }
            humanWeights["Pepi"] = 28;
            humanWeights["Pepi"] = 29;
            //Второто променя предходното (25->26 ред)

            foreach (var item in humanWeights)
            {
                Console.WriteLine($"Key: {item.Key} \n Value: {item.Value}");
                Console.WriteLine($"Person: {item.Key} \n Weight: {item.Value} ");
            }
        }
    }
}
