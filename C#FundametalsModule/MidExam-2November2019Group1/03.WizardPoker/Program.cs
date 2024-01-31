using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            //adds, inserts, removes, swaps cards in a new deck.
            List<string> cards = Console.ReadLine()
                .Split(':')
                .ToList();

            List<string> deck = new List<string>();

            string input = Console.ReadLine();
            while (input != "Ready")
            {
                string[] splitted = input
                    .Split()
                    .ToArray();
                
                string command = splitted[0];
                string cardName = splitted[1];
                switch (command)
                {
                    case "Add":
                        {
                            if (cards.Contains(cardName))
                            {
                                deck.Add(cardName);
                            }
                            else
                            {
                                Console.WriteLine("Card not found");
                            }
                        };
                        break;
                    case "Insert":
                        {
                            int index = int.Parse(splitted[2]);
                            if (index < 0 && index > cards.Count || cards.IndexOf(cardName) == -1)
                            {
                                Console.WriteLine("Error!");
                            }
                            else
                            {
                                deck.Insert(index, cardName);
                            }
                        };
                        break;
                    case "Remove":
                        {
                            if (deck.Contains(cardName))
                            {
                                deck.Remove(splitted[1]);
                            }
                            else
                            {
                                Console.WriteLine("Card not found.");
                            }
                        };
                        break;
                    case "Swap":
                        {
                            int first = deck.IndexOf(splitted[1]);
                            int second = deck.IndexOf(splitted[2]);

                            string temp = deck[first];
                            deck[first] = deck[second];
                            deck[second] = temp;
                        };
                        break;
                    case "Shuffle":
                        {
                            deck.Reverse();
                        };
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
