using System;

namespace Program;

public class Wizard : Personaje
{
    public SpellBook SpellBook { get; set; }
    public Wizard(string name, int Initial_health, int Current_health) : base(name, "Wizard", Initial_health, Current_health)
    {
    }
    private bool HaveSpellBook()
    {
        return (SpecificItems.ContainsKey(typeof(SpellBook)));
    }
    public virtual void UseSpell(Spell spell, Personaje target, SpellBook spellBook)
    {
        if (HaveSpellBook() && SpecificItems[typeof(SpellBook)] == spellBook)
        {
            if (spellBook.spellsAvailable != null && spell.Uses > 0 && spellBook.spellsAvailable.Contains(spell))
            {
                Console.WriteLine($"{Name} ha usado el hechizo {spell.Name} de elemento {spell.Element}!.");
                spell.Uses--;
                Attack(target, spell.Damage);
            }

            else if (spell.Uses == 0)
            {
                Console.WriteLine($"Has gastado tu hechizo {spell.Name}!");
            }
            else
            {
                Console.WriteLine($"{Name} no tiene el hechizo {spell.Name} en su grimorio!");
            }
        }
        else
        {
            Console.WriteLine($"{Name} no tiene un grimorio, o no puede usar un grimorio ajeno!");
        }
    }
}