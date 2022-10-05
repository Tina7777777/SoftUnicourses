using System;
using System.Numerics;

namespace _11Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBalls = int.Parse(Console.ReadLine());
           
            BigInteger highestSnowballsValue = 0;
            int snow1 = 0;
            int time1= 1;
            int quality1 = 0;

            for (int i = 0; i < numBalls; i++)
            {
                 int snow = int.Parse(Console.ReadLine());
                 int time = int.Parse(Console.ReadLine());
                 int quality = int.Parse(Console.ReadLine());
                //snowballValue=(snowballSnow / snowballTime) ^ snowballQuality
                BigInteger snowballsValue =BigInteger.Pow(snow / time,quality);
                if (snowballsValue>highestSnowballsValue)
                {
                    highestSnowballsValue = snowballsValue;
                    snow1 = snow;
                    time1 = time;
                    quality1 =quality;
                }
            }
            Console.WriteLine($"{snow1} : {time1} = {highestSnowballsValue} ({quality1})");
        }
    }
}
