using System;
using System.Collections.Generic;
using System.Linq;

namespace Current
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonsDistances = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sumOfNums = 0;

            for (int i = 0; i <= pokemonsDistances.Count - 1; i++)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                for (int o = 0; o < pokemonsDistances.Count - 1; o++)
                {
                    if (currentIndex == o)
                    {
                        int valueRemovedElement = pokemonsDistances[o];
                        sumOfNums += valueRemovedElement;
                        pokemonsDistances.RemoveAt(o);

                        for (int k = 0; k < pokemonsDistances.Count; k++)
                        {
                            if (pokemonsDistances[k] <= valueRemovedElement)
                            {
                                pokemonsDistances[k] += valueRemovedElement;
                            }
                            else
                            {
                                pokemonsDistances[k] -= valueRemovedElement;
                            }
                        }
                    }
                    else if (currentIndex < 0)
                    {
                        int lastElement = pokemonsDistances[pokemonsDistances.Count - 1];
                        int removedElement = pokemonsDistances[0];
                        sumOfNums += removedElement;
                        pokemonsDistances.RemoveAt(pokemonsDistances[0]);
                        pokemonsDistances.Insert(0, lastElement);

                        for (int l = 0; l < pokemonsDistances.Count; l++)
                        {
                            if (pokemonsDistances[l] <= removedElement)
                            {
                                pokemonsDistances[l] += removedElement;
                            }
                            else
                            {
                                pokemonsDistances[l] -= removedElement;
                            }
                        }
                    }
                    else if (currentIndex > pokemonsDistances.Count - 1)
                    {
                        int firstElement = pokemonsDistances[0];
                        int removedElement = pokemonsDistances[pokemonsDistances.Count - 1];
                        sumOfNums += removedElement;
                        pokemonsDistances.RemoveAt(pokemonsDistances.Count - 1);
                        pokemonsDistances.Add(firstElement);

                        for (int m = 0; m < pokemonsDistances.Count; m++)
                        {
                            if (pokemonsDistances[m] <= removedElement)
                            {
                                pokemonsDistances[m] += removedElement;
                            }
                            else
                            {
                                pokemonsDistances[m] -= removedElement;
                            }
                        }
                        break;
                    }
                }
                i--;
            }

            Console.WriteLine(sumOfNums);
        }
    }
}
