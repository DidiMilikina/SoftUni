using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonsBase = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "wubbalubbadubdub")
            {
                var inputTokens = input
                    .Split(new[] { " -> " },
                        StringSplitOptions.RemoveEmptyEntries);
                var name = inputTokens[0];
                var type = inputTokens[1];
                var index = int.Parse(inputTokens[2]);
                if (!pokemonsBase.ContainsKey(name))
                {
                    pokemonsBase.Add(name, new Dictionary<string, int>());
                }
                pokemonsBase[name].Add();

                input = Console.ReadLine();

            }
    }
}
