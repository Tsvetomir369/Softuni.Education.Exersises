using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntC = 0;
            int cntO = 0;
            int cntN = 0;
            string currentWord = string.Empty;
            string word = string.Empty;
            string inputCommad = Console.ReadLine();
            while (inputCommad != "End")
            {
                char letter = char.Parse(inputCommad);
                bool latinSymbols = (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
                bool secretCommand = (letter == 'c' && cntC == 0) || (letter == 'o' && cntO == 0) || (letter == 'n' && cntN == 0);
                if (latinSymbols)
                {
                    if (secretCommand)
                    {
                        switch (letter)
                        {
                            case 'c':
                                cntC++;
                                break;
                            case 'o':
                                cntO ++;
                                break;
                            case 'n':
                                cntN++;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        currentWord += letter;
                    }

                    if (cntC + cntN + cntO == 3)
                    {
                        word += currentWord;
                        word += ' ';
                        currentWord = string.Empty;
                        cntO = 0;
                        cntN = 0;
                        cntC = 0;
                    }
                }
                inputCommad = Console.ReadLine();
            }

            Console.WriteLine(word);
        }
    }
}
