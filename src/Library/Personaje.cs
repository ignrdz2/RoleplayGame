using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Program{
    public abstract class Personaje{
        public string Name { get; set;}
        public int Health { get; set;}
        public List<Item> Items { get; set; }

        public Personaje(string name, int health){
            Name = name;
            Health = health;
            Items = new List<Item>();
        }

        public abstract int CalculateTotalAttack();
        public abstract int CalculateTotalDefense();
        public abstract void Attack(Personaje target, int damage);
        public abstract void Heal();

        

    }
}