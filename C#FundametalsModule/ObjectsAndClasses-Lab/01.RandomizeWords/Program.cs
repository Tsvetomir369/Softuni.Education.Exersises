using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random randomWord = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int index = randomWord.Next(0, words.Count);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
