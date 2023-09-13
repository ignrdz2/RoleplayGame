using System;
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
  }
}