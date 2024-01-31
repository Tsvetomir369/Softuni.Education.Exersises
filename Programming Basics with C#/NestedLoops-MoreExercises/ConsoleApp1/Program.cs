using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skiptedLetter = char.Parse(Console.ReadLine());

            for (char a = start; a <= end; a++)
            {
                if (a == skiptedLetter)
                {
                    continue;
                }
                for (char b = start; b <= end; b++)
                {
                    if (b == skiptedLetter)
                    {
                        continue;
                    }
                    for (char c = start; c <= end; c++)
                    {
                        if (c == skiptedLetter)
                        {
                            continue;
                        }
                        Console.Write($"{a}{b}{c} ");
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}