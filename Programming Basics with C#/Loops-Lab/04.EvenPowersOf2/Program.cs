using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //int result = 1;
            for(int power = 0; power <= n; power++)
            {
                //if (power % 2 ==0)
                //{
                //    Console.WriteLine(result);
                //}
                //result *= 2;
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }
            }
        }
    }
}
