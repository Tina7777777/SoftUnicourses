using System;

namespace _02CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            
            for (int i = 0; i < arr2.Length; i++)
            {
                
                string element = arr2[i];
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (element==arr1[j])
                    {
                        Console.Write( element+" " );
                    }
                }
            }
        }
    }
}
