using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstLetter = (char)('a' + i);
                for (int k = 0; k < n; k++)
                {
                    char secondLetter = (char)('a' + k);
                    for (int j = 0; j < n; j++)
                    {
                        char thirdLetter = (char)('a' + j);
                        Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, thirdLetter);
                    }
                }
            }
        }
    }
}
