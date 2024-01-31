using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNme = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine("{0}{1}{2}",firstNme, delimeter, lastName );
        }
    }
}
