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
        public void AddSpell(Spell spell) // Aprender un hechizo
        {
            spellsAvailable.Add(spell);
            Console.WriteLine($"Se ha agregado el hechizo {spell.Name}");
        }

        public Spell GetSpellByName(string name) // Lo usas para checkear si el hechizo está en el grimorio
        {
            return spellsAvailable.FirstOrDefault(spell => spell.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DefaultSpells() // Crear un set con hechizos predeterminados
        {
            spellsAvailable.Add(new Spell("Fireball", 50, 3, "Fire"));
            spellsAvailable.Add(new Spell("Icebolt", 40, 3, "Ice"));
            spellsAvailable.Add(new Spell("Thunderbolt", 60, 3, "Thunder"));
        }

        public void ShowSpells()
        {
            for (int i = 0; i < spellsAvailable.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {spellsAvailable[i].Name} - {spellsAvailable[i].Element} - {spellsAvailable[i].Damage} - {spellsAvailable[i].Uses}");
            }
        }
    }
}
