using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char j = 'a'; j < 'a' + l; j++)
                    {
                        for (char g = 'a'; g < 'a' + l; g++)
                        {
                            for (int d = 1; d <= n; d++)
                            {
                                if (d > i && d > k)
                                {
                                    Console.Write($"{i}{k}{j}{g}{d} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
