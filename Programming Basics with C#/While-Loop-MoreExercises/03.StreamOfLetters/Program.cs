using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntSymbolC = 0;
            int cntSymbolO = 0;
            int cntSymbolN = 0;
            string currentWord = string.Empty;
            string wordAfter = string.Empty;
            string commandInput = Console.ReadLine();
            while (commandInput != "End")
            {
                char letter = char.Parse(commandInput);
                bool latinSymbols = (letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z');
                bool secretSymbols = (letter == 'c' && cntSymbolC == 0) ||
                                    (letter == 'o' && cntSymbolO == 0) ||
                                    (letter == 'n' && cntSymbolN == 0);
                if (latinSymbols)
                {
                    if (secretSymbols)
                    {
                        switch (letter)
                        {
                            case 'c':
                                cntSymbolC++;
                                break;
                            case 'o':
                                cntSymbolO++;
                                break;
                            case 'n':
                                cntSymbolN++;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        currentWord += letter;
                    }

                    if (cntSymbolC + cntSymbolN + cntSymbolO == 3)
                    {
                        wordAfter += currentWord;
                        wordAfter += ' ';
                        currentWord = string.Empty;
                        cntSymbolC = 0;
                        cntSymbolN = 0;
                        cntSymbolO = 0;
                    }
                }
                commandInput = Console.ReadLine();
            }
            Console.WriteLine(wordAfter);
        }
    }
}
