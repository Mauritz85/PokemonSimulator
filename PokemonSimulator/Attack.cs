using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSimulator
{
    public class Attack
    {
        public string Name { get; }
        public ElementType Type { get; }
        public int Basepower { get; }

        public Attack (string name, ElementType type, int basepower)
        {
            Name = name;
            Type = type;
            Basepower = basepower;
        }

        public void Use(int level)
        {
            int totalPower = Basepower + level;
            Console.WriteLine($"{Name} hits with total power of {totalPower}");
        }
    }
}
