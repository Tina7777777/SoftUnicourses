using System;
using System.Collections.Generic;
using System.Linq;

namespace _06CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstPlayerCard.Count > 0 && secondPlayerCard.Count > 0)
            {

                if (firstPlayerCard[0] > secondPlayerCard[0])
                {
                    firstPlayerCard.Add(firstPlayerCard[0]);
                    firstPlayerCard.Add(secondPlayerCard[0]);
                    RemoveFirstCard(firstPlayerCard, secondPlayerCard);
                }
                else if (secondPlayerCard[0] > firstPlayerCard[0])
                {
                    secondPlayerCard.Add(secondPlayerCard[0]);
                    secondPlayerCard.Add(firstPlayerCard[0]);
                    RemoveFirstCard(firstPlayerCard, secondPlayerCard);
                }
                else if (firstPlayerCard[0] == secondPlayerCard[0])
                {
                    RemoveFirstCard(firstPlayerCard, secondPlayerCard);
                }
            }
            if (firstPlayerCard.Count > 0)
            {

                Console.WriteLine($"First player wins! Sum: {firstPlayerCard.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCard.Sum()}");
            }
        }

        private static void RemoveFirstCard(List<int> firstPlayerCard, List<int> secondPlayerCard)
        {
            firstPlayerCard.Remove(firstPlayerCard[0]);
            secondPlayerCard.Remove(secondPlayerCard[0]);
        }
    }
}
