namespace _11.Pokemon_Trainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        public string name;
        public int numBadges;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.numBadges = 0;
            this.pokemons = new List<Pokemon>();
        }
    }
}