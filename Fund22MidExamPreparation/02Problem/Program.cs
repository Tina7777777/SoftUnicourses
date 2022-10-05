using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Problem
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> purchaseList = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            while (input!= "No More Money")
            {
                string[] splittedInput = input.Split(" ");
                string command = splittedInput[0];
                string biscuitsType = splittedInput[1];
                if (command== "OutOfStock")
                {
                    if (purchaseList.Contains(biscuitsType))
                    {
                        
                        for (int i = 0; i < purchaseList.Count; i++)
                        {
                            if (purchaseList[i]==biscuitsType)
                            {
                                purchaseList.Remove(biscuitsType);
                                purchaseList.Insert(i," ");
                                
                            }
                        }
                    }
                }
                if (command == "Required")
                {
                    string number = splittedInput[2];
                    int index = int.Parse(number);
                    if (index<=purchaseList.Count-1 && purchaseList[index]!=" " )
                    {
                        purchaseList.RemoveAt(index);
                        purchaseList.Insert(index, biscuitsType);
                    }
                }
                if (command == "Last")
                {
                    purchaseList.Add(biscuitsType);
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine(String.Join(" ", purchaseList));
        }
    }
}
