using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args){
            //Se crea un personaje de tipo mago
            Wizard wizard = new Wizard("Axel", 100, 100);
            wizard.Items.Add(new Item("Palo", 20, 10));
            wizard.Items.Add(new Item("Libro", 0, 15));

            int Wizard_totalAttack = wizard.CalculateTotalAttack();
            int Wizard_totalDefense = wizard.CalculateTotalDefense();
            //

            //Se crea un personaje de tipo Elfo
            Elfo elfo = new Elfo("Pedrozo", 90, 90);
            elfo.Items.Add(new Item("Garrafa", 25, 0));
            elfo.Items.Add(new Item("Escudo", 0, 30));

            int Elfo_totalAttack = elfo.CalculateTotalAttack();
            int Elfo_totalDefense = elfo.CalculateTotalDefense();
            //

            //Se cera un personaje tipo Enano
            Enano enano = new Enano("Agario", 70, 70);
            enano.Items.Add(new Item("Palito", 40, 1));
            enano.Items.Add(new Item("Armadura", 0, 50));

            int Enano_totalAttack = enano.CalculateTotalAttack();
            int Enano_totalDefense = enano.CalculateTotalDefense();
            //

            // vvvvvvvvvv
            //Falta sacar el damage de cada item para al atacar indicar el item y no el damage directamente
            // ^^^^^^^^^^
            wizard.Attack(elfo, 20); // 
            wizard.Attack(elfo, 20);
            wizard.Heal(elfo);


            Console.WriteLine($"{wizard.Name} | Vida: {wizard.Current_health} - Total Attack: {Wizard_totalAttack}, Total Defense: {Wizard_totalDefense}");
        }
    }
}
