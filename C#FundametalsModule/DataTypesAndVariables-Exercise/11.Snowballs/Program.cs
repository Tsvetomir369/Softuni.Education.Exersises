using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numSnowBalls = byte.Parse(Console.ReadLine());
            BigInteger highestValue = int.MinValue;
            short highestSnow = 0;
            short highestTime = 0;
            short highestQuality = 0;
            for (int i = 1; i <= numSnowBalls; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                short snowballQuality = short.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowballTime) , snowballQuality);
                if (snowBallValue > highestValue)
                {
                    highestValue = snowBallValue;

                    highestSnow = snowBallSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
