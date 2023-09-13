using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Linq;

namespace Program
{
    public class Spell
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Uses { get; set; }

        public string Element { get; set; }
        public Spell(string name, int damage, int uses, string element)
        {
            Name = name;
            Damage = damage;
            Uses = uses;
            Element = element;
        }
    }
    public class SpellBook
    {
        public List<Spell> spellsAvailable = new List<Spell>();
        public void AddSpell(Spell spell)
        {
            spellsAvailable.Add(spell);
            Console.WriteLine($"Se ha agregado el hechizo {spell.Name}");
        }

        public Spell GetSpellByName(string name) // Lo usas para checkear si el hechizo está en el grimorio
        {
            return spellsAvailable.FirstOrDefault(spell => spell.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
