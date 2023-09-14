using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Program
{
    public abstract class Personaje
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Initial_health { get; set; }
        public int Current_health { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<Type, object> SpecificItems { get; set; }

        public Personaje(string name, string category, int initial_health, int current_health)
        {
            Name = name;
            Initial_health = initial_health;
            Current_health = current_health;
            Category = category;
            Items = new List<Item>();
            SpecificItems = new Dictionary<Type, object>(); /* Sirve para que algunas clases no puedan tener cosas de las otras
            Por ejemplo, ninguna clase puede tener un SpellBook excepto los magos */
        }

        public virtual int CalculateTotalAttack()
        {
            int totalAttack = 0;
            foreach (var item in Items)
            {
                totalAttack += item.Attack;
            }

            return totalAttack;
        }
        public virtual int CalculateTotalDefense()
        {
            int totalDefense = 0;
            foreach (var item in Items)
            {
                totalDefense += item.Defense;
            }

            return totalDefense;
        }
        public virtual void Attack(Personaje target, int damage)
        {
            Console.WriteLine(target.Current_health);
            target.Current_health -= damage;
            Console.WriteLine($"{target.Name} fue atacado con {damage} de damage, su vida ahora es de {target.Current_health}");
            //Falta poder saber por quien fue atacado el target
        }
        public virtual void Heal(Personaje target)
        {
            target.Current_health = target.Initial_health;
            Console.WriteLine($"{target.Name} ha sido curado! | Vida: {target.Current_health}");
            //Falta poder saber por quien fue curado el target
        }
    }
}