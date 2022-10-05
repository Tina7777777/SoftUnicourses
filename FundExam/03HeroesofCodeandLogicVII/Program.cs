using System;
using System.Collections.Generic;

namespace _03HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> herosHP = new Dictionary<string, int>();
            Dictionary<string, int> herosMP = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int hp = int.Parse(splitted[1]);
                int mp = int.Parse(splitted[2]);

                herosHP.Add(name, hp);
                herosMP.Add(name, mp);

            }
        }
    }
}
