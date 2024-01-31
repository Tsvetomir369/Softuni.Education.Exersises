using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int largest = Math.Max(Math.Max(num1, num2), num3);

            if (largest == num1)
            {
                Console.WriteLine(num1);
                Console.WriteLine(Math.Max(num2,num3));
                Console.WriteLine(Math.Min(num2,num3));
            }
            else if (largest == num2)
            {
                Console.WriteLine(num2);
                Console.WriteLine(Math.Max(num1, num3));
                Console.WriteLine(Math.Min(num1, num3));
            }
            else
            {
                Console.WriteLine(num3);
                Console.WriteLine(Math.Max(num2, num1));
                Console.WriteLine(Math.Min(num2, num1));
            }
        }
    }
}
