using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firstIndex = byte.Parse(Console.ReadLine());
            byte secondIndex = byte.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                char asciiChar = (char)i;
                Console.Write("{0} ",asciiChar);
            }
        }
    }
}
