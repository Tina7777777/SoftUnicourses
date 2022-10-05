using System;
using System.Linq;

namespace LadyBugsRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ladyBugs = new int[int.Parse(Console.ReadLine())];
            int[] indexesOfLadyBugs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < indexesOfLadyBugs.Length; i++)
            {
                if (indexesOfLadyBugs[i] >= 0 && indexesOfLadyBugs[i] < ladyBugs.Length) //!!!
                {
                    ladyBugs[indexesOfLadyBugs[i]] = 1;
                }
            }
            //int n = int.Parse(Console.ReadLine());
            //int[] indexes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int[] ladyBugs = new int[n];
            //for (int i = 0; i < indexes.Length; i++)
            //{
            //    int index = indexes[i];
            //    if (index >= 0 && index < n)
            //    {
            //        ladyBugs[index] = 1;
            //    }
            //}
            //for (int j = 0; j < n; j++)
            //{
            //    if (ladyBugs[j]!=1)
            //    {
            //        ladyBugs[j] = 0;
            //    }
            //}
            // Console.WriteLine(string.Join(" ",ladyBugs));
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splitedCommand = command.Split();
                int ladybugIndex = int.Parse(splitedCommand[0]);
                string direction = splitedCommand[1];
                int flyLength = int.Parse(splitedCommand[2]);
                if (ladybugIndex >= 0 && ladybugIndex < ladyBugs.Length)
                {
                    if (ladyBugs[ladybugIndex] == 1 && direction == "right"&& flyLength != 0)
                    {
                        int ladybugNewPosition = ladybugIndex + flyLength;
                        if (ladybugNewPosition < ladyBugs.Length && ladybugNewPosition >= 0)
                        {
                            if (ladyBugs[ladybugNewPosition] == 0)
                            {
                                ladyBugs[ladybugNewPosition] = 1;
                            }
                            else
                            {
                                while (true)
                                {
                                   
                                    ladybugNewPosition += flyLength;
                                    if (ladybugNewPosition >= ladyBugs.Length || ladybugNewPosition < 0)
                                    {
                                        break;
                                    }
                                    else if (ladyBugs[ladybugNewPosition] == 0)
                                    {
                                        ladyBugs[ladybugNewPosition] = 1;
                                        break;
                                    }
                                }
                            }
                        }

                        ladyBugs[ladybugIndex] = 0;
                    }
                    else if (ladyBugs[ladybugIndex] == 1 && direction == "left"&&flyLength!=0)
                    {
                        int ladybugNewPosition = ladybugIndex - flyLength;
                        if (ladybugNewPosition < ladyBugs.Length && ladybugNewPosition >= 0)
                        {
                            if (ladyBugs[ladybugNewPosition] == 0)
                            {
                                ladyBugs[ladybugNewPosition] = 1;
                            }
                            else
                            {
                                while (true)
                                {
                                   
                                    ladybugNewPosition -= flyLength;
                                    if (ladybugNewPosition > ladyBugs.Length || ladybugNewPosition < 0)
                                    {
                                        break;
                                    }
                                    else if (ladyBugs[ladybugNewPosition] == 0)
                                    {
                                        ladyBugs[ladybugNewPosition] = 1;
                                        break;
                                    }

                                }
                            }
                        }
                        ladyBugs[ladybugIndex] = 0;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
