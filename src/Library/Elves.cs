using System;
namespace Program;
public class Elfo : Personaje
{
        public Elfo(string name, int health) : base(name, health)
    {
    }

    public override int CalculateTotalAttack()
    {
        int totalAttack = 0;
        foreach (var item in Items)
        {
            totalAttack += item.Attack;
        }
        return totalAttack;
    }

    public override int CalculateTotalDefense()
    {
        int totalDefense = 0;
        foreach (var item in Items)
        {
            totalDefense += item.Defense;
        }
        return totalDefense;
    }

    public override void Attack(Personaje target, int damage)
    {
        // Implementa la lógica de ataque
    }

    public override void Heal()
    {
        // Implementa la lógica de curación
    }
}