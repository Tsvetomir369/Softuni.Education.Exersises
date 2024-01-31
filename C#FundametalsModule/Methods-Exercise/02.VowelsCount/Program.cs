using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            GetCntVowels(text);
        }

        static void GetCntVowels (string text)
        {
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y' };
            int countVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {

                //if (vowels.Contains(text[i]))
                //{
                //    countVowels++;
                //}
                switch (text[i])
                {
                    case 'a':
                        countVowels++;
                        break;
                    case 'e':
                        countVowels++;
                        break;
                    case 'i':
                        countVowels++;
                        break;
                    case 'o':
                        countVowels++;
                        break;
                    case 'u':
                        countVowels++;
                        break;
                    case 'y':
                        countVowels++;
                        break;
                }
            }

            Console.WriteLine(countVowels);
        }
    }
}
