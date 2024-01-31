using System;

namespace _02._Pasword
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string userPassword = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != userPassword)
            {

                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
