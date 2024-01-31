using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, num * multiplier);
                multiplier++;
            } while (multiplier <= 10);

            //if (multiplier > 10)
            //{
            //    Console.WriteLine("{0} X {1} = {2}", num, multiplier, num * multiplier);
            //}
            //else
            //{
            //    for (int i = multiplier; i <= 10; i++)
            //    {
            //        Console.WriteLine("{0} X {1} = {2}", num, i, num * i);
            //    }
            //}
        }
    }
}
