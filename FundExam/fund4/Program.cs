using System;
using System.Collections.Generic;
using System.Linq;

namespace fund4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var splited = Console.ReadLine().Split();
                string name = splited[0];
                int hp = int.Parse(splited[1]);
                int mp = int.Parse(splited[2]);

                heroesHP.Add(name, hp);
                heroesMP.Add(name, mp);

            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spelName = splitted[3];

                    if (heroesMP[heroName]<mpNeeded)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spelName}!");
                    }
                    else
                    {
                        heroesMP[heroName] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spelName} and now has {heroesMP[heroName]} MP!");  
                    }
                }
                if (command.Contains("TakeDamage"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int damaged = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    if (heroesHP[heroName] <= damaged)
                    {
                        heroesHP[heroName] = 0;
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                    else
                    {
                        heroesHP[heroName] -= damaged;
                        Console.WriteLine($"{heroName} was hit for {damaged} HP by {attacker} and now has {heroesHP[heroName]} HP left!");
                    }
                }
                if (command.Contains("Recharge"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroesMP[heroName]+amount>200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200-heroesMP[heroName]} MP!");
                        heroesMP[heroName] = 200;
                    }
                    else
                    {
                        heroesMP[heroName] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        
                    }
                  
                }
                if (command.Contains("Heal"))
                {
                    var splitted = command.Split(" - ");
                    string heroName = splitted[1];
                    int amount = int.Parse(splitted[2]);

                    if (heroesHP[heroName] + amount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroesHP[heroName]} HP!");
                        heroesHP[heroName] = 100;
                    }
                    else
                    {
                        heroesHP[heroName] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");

                    }

                }

                command = Console.ReadLine();
            }
            heroesHP = heroesHP
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var hero in heroesHP)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroesMP[hero.Key]}");
            }
        }
    }
}
