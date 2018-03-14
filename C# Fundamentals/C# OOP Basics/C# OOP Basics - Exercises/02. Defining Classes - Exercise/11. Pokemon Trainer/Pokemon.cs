namespace _11.Pokemon_Trainer
{
    public class Pokemon
    {
        public string name;
        public string pokemonElement;
        public int pokemonHealth;

        public Pokemon(string name, string pokemonElement, int pokemonHealth)
        {
            this.name = name;
            this.pokemonElement = pokemonElement;
            this.pokemonHealth = pokemonHealth;
        }
    }
}