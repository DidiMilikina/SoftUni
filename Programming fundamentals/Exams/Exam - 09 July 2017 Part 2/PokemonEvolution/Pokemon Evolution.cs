using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Pokemon
    {
        public string Type { get; set; }
        public int Index { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pokemonsBase = new Dictionary<string, List<Pokemon>>();
            string input;

            
            while ((input = Console.ReadLine()) != "wubbalubbadubdub")
            {
                if (pokemonsBase.ContainsKey(input))
                {
                    Console.WriteLine($"# {input}");
                    foreach (var pokemon in pokemonsBase[input])
                    {
                        Console.WriteLine($"{pokemon.Type} <-> {pokemon.Index}");
                    }
                }
                 else
                {
                    var inputTokens = input
                        .Split(new[] { " -> " },
                            StringSplitOptions.RemoveEmptyEntries);

                    if (inputTokens.Length != 3)
                    {
                        continue;
                    }

                    var pokemonName = inputTokens[0];
                    var evolutionType = inputTokens[1];
                    var evolutionIndex = int.Parse(inputTokens[2]);

                    if (!pokemonsBase.ContainsKey(pokemonName))
                    {
                        pokemonsBase.Add(pokemonName, new List<Pokemon>());
                    }

                    var currentPokemon = new Pokemon()
                    {
                        Type = evolutionType,
                        Index = evolutionIndex
                    };
                    pokemonsBase[pokemonName].Add(currentPokemon);

                }
            }
      

            foreach (var pokemonEvolutionKVP in pokemonsBase)
            {
                var sortedEvolutions = pokemonEvolutionKVP.Value.OrderByDescending(pokemon => pokemon.Index);
                Console.WriteLine($"# {pokemonEvolutionKVP.Key}");
                foreach (var pokemon in sortedEvolutions)
                {
                    Console.WriteLine($"{pokemon.Type} <-> {pokemon.Index}");
                }
            }
        }
    }
}
