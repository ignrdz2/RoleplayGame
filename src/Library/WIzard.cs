using System;

namespace Program;

public class Wizard : Personaje{
    public Wizard(string name, int Initial_health, int Current_health) : base(name, "Wizard", Initial_health, Current_health){

    }
    public override int CalculateTotalAttack(){
        int totalAttack = 0;
        foreach(var item in Items){
            totalAttack += item.Attack;
        }

        return totalAttack;
    }
    public override int CalculateTotalDefense()
    {
        int totalDefense = 0;
        foreach(var item in Items){
            totalDefense += item.Defense;
        }

        return totalDefense;
    }   
    public override void Attack(Personaje target, int damage)
    {
        Console.WriteLine(target.Current_health);
        target.Current_health -= damage;
        Console.WriteLine($"{target} fue atacado con {damage} de damage, su vida ahora es de {target.Current_health}");
    }
    public override void Heal()
    {
        throw new System.NotImplementedException();
    }
}