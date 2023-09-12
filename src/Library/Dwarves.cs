namespace Program
{
  public class Enano : Personaje
  {
    public Enano(string name, int Initial_health, int Current_health) : base(name, "Enano", Initial_health, Current_health)
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
}