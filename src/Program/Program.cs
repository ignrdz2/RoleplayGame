using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard axeloncio = new Wizard("Axeloncio", 100, 100);
            Wizard leoSalle = new Wizard("Panzas", 100, 100);

            SpellBook grimorio = new SpellBook();
            axeloncio.SpecificItems[typeof(SpellBook)] = grimorio; //Agregar un grimorio para axeloncio
            
            Spell FireBall = new Spell("Bola de fuego", 23, 3, "fuego");
            grimorio.AddSpell(FireBall);
            axeloncio.UseSpell(FireBall, leoSalle, grimorio);
            leoSalle.UseSpell(FireBall, axeloncio, grimorio);

            Enano enanito = new Enano("Enanito", 150, 150);
            enanito.SpecificItems[typeof(SpellBook)] = grimorio;
            //Console.WriteLine($"{wizard.Name} | Vida: {wizard.Current_health} - Total Attack: {Wizard_totalAttack}, Total Defense: {Wizard_totalDefense}");
        }
    }
}
