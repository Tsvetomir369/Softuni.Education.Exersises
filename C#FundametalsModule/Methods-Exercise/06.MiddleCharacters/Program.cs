using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            GetMiddleCharacters(text);
        }

        static void GetMiddleCharacters (string text)
        {
            string result = "";
            if (text.Length % 2 == 0)
            {
                result = text.Substring((text.Length / 2) - 1, 2);
                Console.WriteLine(result);
                //Console.WriteLine(text.Substring((text.Length / 2) - 1, 2));
            }
            else
            {
                result = text[text.Length / 2].ToString();
                Console.WriteLine(result);
                //Console.WriteLine(text[text.Length /2]);
            }
        }
    }
}
