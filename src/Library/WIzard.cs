namespace Program;

public class Wizard : Personaje{
    public Wizard(string name, int health) : base(name, "Wizard", health){

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
        throw new System.NotImplementedException();
    }
    public override void Heal()
    {
        throw new System.NotImplementedException();
    }
}