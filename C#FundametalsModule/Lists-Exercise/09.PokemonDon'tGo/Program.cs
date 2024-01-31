using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sumOfRemovedNums = 0;

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());


                if (index < 0)
                {
                    var removeElementCase1 = pokemons[0];
                    sumOfRemovedNums += removeElementCase1;
                    pokemons[0] = pokemons[pokemons.Count - 1];

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removeElementCase1)
                        {
                            pokemons[i] += removeElementCase1;
                        }
                        else
                        {
                            pokemons[i] -= removeElementCase1;
                        }
                    }
                }
                else if (index >= pokemons.Count)
                {
                    var removeElementCase2 = pokemons[pokemons.Count - 1];
                    sumOfRemovedNums += removeElementCase2;
                    pokemons[pokemons.Count - 1] = pokemons[0];

                    for (int i = 0; i < pokemons.Count; i++) 
                    {
                        if (pokemons[i] <= removeElementCase2)
                        {
                            pokemons[i] += removeElementCase2;
                        }
                        else
                        {
                            pokemons[i] -= removeElementCase2;
                        }
                    }
                }
                else
                {
                    var removeElementCase3 = pokemons[index];
                    sumOfRemovedNums += removeElementCase3;
                    pokemons.RemoveAt(index);

                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= removeElementCase3)
                        {
                            pokemons[i] += removeElementCase3;
                        }
                        else
                        {
                            pokemons[i] -= removeElementCase3;
                        }
                    }
                }
            }

            Console.WriteLine(sumOfRemovedNums);
        }
    }
}
