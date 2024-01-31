using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string text)
        {
            var reversedText = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if (reversedText[i] != text[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
