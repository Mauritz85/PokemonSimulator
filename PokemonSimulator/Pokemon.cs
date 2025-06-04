namespace PokemonSimulator;

public abstract class Pokemon
{
    private string name = string.Empty;
    private int level;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 15)
                throw new ArgumentException("Namnet måste vara 2–15 tecken.");
            name = value;
        }
    }

    public int Level
    {
        get => level;
        set
        {
            if (value < 1)
                throw new ArgumentException("Level måste vara minst 1.");
            level = value;
        }
    }

    public ElementType Type { get; protected set; }

    public List<Attack> Attacks { get; }

    public Pokemon(string name, int level, List<Attack> attacks)
    {
        Name = name;
        Level = level;
        Attacks = attacks;
    }

    public void RandomAttack()
    {
        var random = new Random();
        var attack = Attacks[random.Next(Attacks.Count)];
        attack.Use(Level);
    }

    public void Attack()
    {
        Console.WriteLine($"Välj en attack för {Name}:");
        for (int i = 0; i < Attacks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Attacks[i].Name}");
        }

        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Attacks.Count)
        {
            Attacks[choice - 1].Use(Level);
        }
        else
        {
            Console.WriteLine("Ogiltigt val.");
        }
    }

    public void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    }
}
