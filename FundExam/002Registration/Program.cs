using System;
using System.Collections.Generic;
using System.Linq;

namespace _002Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> clients = new Dictionary<string, double>();
            Dictionary<string, double> distributors = new Dictionary<string, double>();
            string input = Console.ReadLine();

            while (input!= "End")
            {
                string[] inputInfo = input.Split();

                string command = inputInfo[0];
                string name = inputInfo[1];
                double money = double.Parse(inputInfo[2]);
                if (command== "Deliver")
                {
                    if (!distributors.ContainsKey(name))
                    {
                        distributors.Add(name, money);
                    }
                    else
                    {
                        distributors[name] += money;    
                    }
                }
                if (command== "Return")
                {
                    if (!distributors.ContainsKey(name))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        if (distributors[name]<money)
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            distributors[name] -= money;
                            if (distributors[name]<=0)
                            {
                                distributors.Remove(name);
                            }
                        }
                    }
                }
                if (command == "Sell")
                {
                    if (!clients.ContainsKey(name))
                    {
                        clients.Add(name, money);
                    }
                    else
                    {
                        clients[name] += money;
                    }
                }

                input = Console.ReadLine();
            }
            clients = clients.OrderBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);
            distributors=distributors.OrderBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);
            double sum = 0;
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Key}: {client.Value:f2}");
                sum += client.Value;
            }
            Console.WriteLine("-----------");
            foreach (var distributor in distributors)
            {
                Console.WriteLine($"{distributor.Key}: {distributor.Value:f2}");
            }
            Console.WriteLine("-----------");
            Console.WriteLine($"Total Income: {sum:f2}");
            
        }
    }
}
