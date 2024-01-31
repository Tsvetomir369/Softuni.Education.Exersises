using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());

            string combine = input1.ToString() + input2.ToString() + input3.ToString();
            Console.WriteLine(combine);
        }
    }
}
