using System;

namespace _01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string name = Console.ReadLine();
            while (name != "Stop")
            {
                counter++;
                name = Console.ReadLine();
            }

            Console.WriteLine(counter);
        }
    }
}
