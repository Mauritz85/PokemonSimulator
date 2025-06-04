
namespace PokemonSimulator
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name, int level, List<Attack> attacks)
            : base(name, level, attacks)
        {
            Type = ElementType.Fire;
        }
    }

    public class WaterPokemon : Pokemon
    {
        public WaterPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, attacks)
        {
            Type = ElementType.Water;
        }
    }

    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, attacks)
        {
            Type = ElementType.Electric;
        }
    }

}
