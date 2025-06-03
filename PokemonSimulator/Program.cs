namespace PokemonSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        static void Init()
        {
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
        }
    }
}
