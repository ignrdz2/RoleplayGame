    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using Program;

namespace Program
{
    public class Game
    {

        public static Personaje CreateCharacter()
        {
        Console.WriteLine("Seleccione el tipo de personaje:");
        Console.WriteLine("1. Mago");
        Console.WriteLine("2. Elfo");
        Console.WriteLine("3. Enano");
        Console.WriteLine("4. Salir");

        int option = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Ingrese el nombre del personaje:");
        string name = Console.ReadLine();
        Personaje personaje = null;
        if (option == 1)
        {
            personaje = new Wizard(name, 100, 100);
        }
        else if (option == 2)
        {
            personaje = new Elfo(name, 90, 90);
        }
        else if (option == 3)
        {
            personaje = new Enano(name, 70, 70);
        }
        else if (option == 4)
        {
            Console.WriteLine("Gracias por jugar!");
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }

        return personaje;
        }

        public static void AddItem(Personaje personaje)
        {
            Console.WriteLine("Ingrese el nombre del item:");
            string itemName = Console.ReadLine().ToLower().Trim();
            if (itemName == "grimorio" && personaje is Wizard)
            {
                SpellBook grimorio = new SpellBook();
                personaje.SpecificItems[typeof(SpellBook)] = grimorio;
                grimorio.DefaultSpells();
                Console.WriteLine($"Se ha agregado un grimorio mágico a {personaje.Name}!");
                grimorio.ShowSpells();
            }
            else
            {
            Console.WriteLine("Ingrese el ataque del item:");
            int itemAttack = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la defensa del item:");
            int itemDefense = Convert.ToInt32(Console.ReadLine());

            Item item = new Item(itemName, itemAttack, itemDefense);
            personaje.Items.Add(item);
            }
        }

        // public static void ShowCharacters(List<Personaje> personajes)
        // {
        // string json = JsonSerializer.Serialize(personajes);
        // // Console.WriteLine(json);
        // foreach (var item in personajes)
        //     Console.WriteLine($"Nombre: {item.Name} | Tipo: {item.Category} | Vida: {item.Current_health} | Ataque: {item.CalculateTotalAttack()} | Defensa: {item.CalculateTotalDefense()}");
        // }
    }
}