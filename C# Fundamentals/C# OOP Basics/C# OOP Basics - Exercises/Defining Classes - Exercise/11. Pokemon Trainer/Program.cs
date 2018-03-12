using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (command != "Tournament")
            {
                string[] tokens = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                if (!trainers.Any(t => t.name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                var trainer = trainers.First(t => t.name == trainerName);
                trainer.pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.pokemons.Any(p => p.pokemonElement == command))
                    {
                        trainer.numBadges++;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.pokemons)
                        {
                            pokemon.pokemonHealth -= 10;
                        }

                        trainer.pokemons = trainer
                            .pokemons
                            .Where(p => p.pokemonHealth > 0)
                            .ToList();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.numBadges))
            {
                Console.WriteLine($"{trainer.name} {trainer.numBadges} {trainer.pokemons.Count}");
            }
        }
    }
}
