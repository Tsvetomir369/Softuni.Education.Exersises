using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                //string numbers = Console.ReadLine();
                //int num1 = int.Parse(numbers);
                //int num2 = int.Parse(numbers);
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                Console.WriteLine(num1,num2);
            }
        }
    }
}
