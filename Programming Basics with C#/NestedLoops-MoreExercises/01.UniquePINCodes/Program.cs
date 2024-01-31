using System;

namespace _01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Първата и третата цифра трябва да бъдат четни.
            //Втората цифра трябва да бъде просто число в диапазона[2...7].

            for (int i = 2; i <= num1; i += 2)
            {
                for (int k = 2; k <= num2; k++)
                {
                    for (int l = 2; l <= num3; l += 2)
                    {
                        if (k == 2 || k == 3 || k == 5 || k == 7)
                        {
                            Console.WriteLine($"{i} {k} {l}");
                        }
                    }
                }
            }
        }
    }
}
