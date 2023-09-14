using System;

namespace Program;

public class Wizard : Personaje
{
    public SpellBook SpellBook { get; set; }
    public Wizard(string name, int Initial_health, int Current_health) : base(name, "Wizard", Initial_health, Current_health)
    {
    }
    public bool HaveSpellBook()
    {
        return (SpecificItems.ContainsKey(typeof(SpellBook)));
    }
    public virtual void UseSpell(Spell spell, Personaje target, SpellBook spellBook)
    {
        if (HaveSpellBook())
        {
            if (spellBook.spellsAvailable != null && spell.Uses > 0)
            {
                Console.WriteLine($"{Name} ha usado el hechizo {spell.Name} de elemento {spell.Element}!.");
                spell.Uses--;
                Attack(target, spell.Damage);
            }

            else if (spell.Uses == 0)
            {
                Console.WriteLine($"Has gastado tu hechizo {spell.Name}!");
            }
        }
    }
    // public override int CalculateTotalAttack()
    // {
    //     int totalAttack = 0;
    //     foreach (var item in Items)
    //     {
    //         totalAttack += item.Attack;
    //     }

    //     return totalAttack;
    // }
    // public override int CalculateTotalDefense()
    // {
    //     int totalDefense = 0;
    //     foreach (var item in Items)
    //     {
    //         totalDefense += item.Defense;
    //     }

    //     return totalDefense;
    // }
    // public override void Attack(Personaje target, int damage)
    // {
    //     Console.WriteLine(target.Current_health);
    //     target.Current_health -= damage;
    //     Console.WriteLine($"{target.Name} fue atacado con {damage} de damage, su vida ahora es de {target.Current_health}");
    //     //Falta poder saber por quien fue atacado el target
    // }
    // public override void Heal(Personaje target)
    // {
    //     target.Current_health = target.Initial_health;
    //     Console.WriteLine($"{target.Name} ha sido curado! | Vida: {target.Current_health}");
    //     //Falta poder saber por quien fue curado el target
    // }
}