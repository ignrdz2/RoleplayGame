﻿using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Personaje de Axel Pedrozo
            Wizard axeloncio = new Wizard("Axeloncio", 100, 100);
            //Items (libro de hechizos + un hechizo)
            SpellBook grimorio = new SpellBook();
            axeloncio.SpecificItems[typeof(SpellBook)] = grimorio; //Agregar un grimorio para axeloncio
            Spell FireBall = new Spell("Bola de fuego", 23, 3, "fuego");
            grimorio.AddSpell(FireBall);

            // Personaje de Juan Ignacio Cama
            Wizard juani = new Wizard("Juani", 100, 100);
            //Items (libro de hechizos + un hechizo)
            SpellBook grimorio2 = new SpellBook();
            juani.SpecificItems[typeof(SpellBook)] = grimorio2; //Agregar un grimorio para juani
            Spell DarkLight = new Spell("Rayo oscuro", 10, 10, "oscuridad");
            grimorio.AddSpell(DarkLight);

            // Personaje de Juan Ignacio Rodriguez
            Elfo juancho = new Elfo("Juancho", 100, 100);
            //Items:
            juancho.Items.Add(new Item("Arco", 2, 2));
            juancho.Items.Add(new Item("Flechas", 10, 0));

            // Personaje de Gaston Bauer
            Enano gebau = new Enano("Gebau", 100, 100);
            //Items:
            gebau.Items.Add(new Item("Hacha", 8, 1));
            gebau.Items.Add(new Item("Escudo", 0, 5));
            //Calculo de ataque y defensa
            Console.WriteLine("El ataque total de gebau es: {0}", gebau.CalculateTotalAttack());
            Console.WriteLine("La defensa de gebau es: {0}", gebau.CalculateTotalDefense());

            //Ataque de axeloncio a juani
            axeloncio.UseSpell(FireBall, juani, grimorio);

            //Ataque de juani a axeloncio
            juani.UseSpell(DarkLight, axeloncio, grimorio2);

            //Ataque de juancho a gebau
            juancho.Attack(gebau, juancho.CalculateTotalAttack());


        }
    }
}