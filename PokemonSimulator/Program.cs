namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var waterGun = new Attack("Water Gun", ElementType.Water, 10);
            var splash = new Attack("Splash", ElementType.Water, 2);

            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 15);
            var spark = new Attack("Spark", ElementType.Electric, 7);

            var charmander = new Charmander(new List<Attack> { flamethrower, ember });
            var squirtle = new Squirtle(new List<Attack> { waterGun, splash });
            var pikachu = new Pikachu(new List<Attack> { thunderbolt, spark });
            

            List<Pokemon> trainerTeam = new List<Pokemon> { charmander, squirtle, pikachu };

            foreach (var pokemon in trainerTeam)
            {
                pokemon.RaiseLevel();
                pokemon.Attack();
                if (pokemon is IEvolvable evolvable)
                {
                    evolvable.Evolve();
                }
            }

        }
    }
}
