﻿using System;
using System.Collections.Generic;


namespace Program
{
    class Program
    {
        static void Play()
        {
            Console.WriteLine("Bienvenido a la batalla de los personajes");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("CREACION DE PERSONAJES");
            var seguir = true;
            Personaje personaje = null;
            List<Personaje> personajes = new List<Personaje>();

            while (seguir)
            {
                System.Threading.Thread.Sleep(500);
                personaje = Game.CreateCharacter();

                Console.WriteLine("Desea agregar item? (Y/N)");

                var answer2 = Console.ReadLine();

                if (answer2.ToLower().Trim() == "y")
                {
                    System.Threading.Thread.Sleep(500);
                    Game.AddItem(personaje);
                }

                personajes.Add(personaje);

                Console.WriteLine($"Se ha creado el personaje {personaje.Name} de tipo {personaje.Category}");

                Console.WriteLine("Quiere crear otro personaje? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.ToLower().Trim() == "n")
                {
                    seguir = false;
                }

            }

            Console.Clear();
            // Game.ShowCharacters(personajes);
            System.Console.WriteLine("COMIENZA LA BATALLA");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("+-----------------------+");
            Console.WriteLine("|+---------------------+|");
            Console.WriteLine("||     PROXIMAMENTE    ||");
            Console.WriteLine("|+---------------------+|");
            Console.WriteLine("+-----------------------+");



        }

        static void Main(string[] args)
        {
            Wizard mago = new Wizard("Axel", 100, 100);
            SpellBook grimorio = new SpellBook();
            mago.SpecificItems[typeof(SpellBook)] = grimorio;

            Enano victima = new Enano("Victima", 100, 100);

            Spell hechizo = new Spell("Llamarada", 20, 5, "Fuego");
            grimorio.AddSpell(hechizo);

            mago.UseSpell(hechizo, victima, grimorio);

            Wizard mago2 = new Wizard("Roberto", 100, 100);
            SpellBook grimorio2 = new SpellBook();
            mago2.SpecificItems[typeof(SpellBook)] = grimorio2;

            // Intentar usar un hechizo que no está en el grimorio
            mago2.UseSpell(hechizo, victima, grimorio2); /* No tiene hechizo en el grimorio */

            // Intentar usar un grimorio ajeno
            mago2.UseSpell(hechizo, victima, grimorio); /* No puede usar grimorio ajeno */

            // Play();
        }
    }
}