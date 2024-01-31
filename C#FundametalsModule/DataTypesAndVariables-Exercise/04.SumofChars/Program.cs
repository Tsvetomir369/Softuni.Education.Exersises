using System;

namespace _04.SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nNumLines = byte.Parse(Console.ReadLine());
            int sumAscii = 0;
            for (int i = 1; i <= nNumLines; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int toAscii = (int)letter;
                sumAscii += toAscii;
            }
            Console.WriteLine("The sum equals: {0}", sumAscii);
        }
    }
}
