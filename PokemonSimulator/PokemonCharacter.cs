namespace PokemonSimulator
{
    public class Charmander : FirePokemon
    {
        public Charmander(List<Attack> attacks)
            : base("Charmander", 5, attacks) { }
    }

    public class Squirtle : WaterPokemon
    {
        public Squirtle(List<Attack> attacks)
            : base("Squirtle", 5, attacks) { }
    }

    public class Pikachu : ElectricPokemon, IEvolvable
    {
        public Pikachu(List<Attack> attacks)
            : base("Pikachu", 15, attacks) { }

        public void Evolve()
        {
            Console.WriteLine($"{Name} is evolving...");
            Name = "Raichu";
            Level += 10;
            Console.WriteLine($"Now it's {Name}! Level {Level}!");
        }
    }
}
