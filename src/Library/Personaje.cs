using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Program{
    public abstract class Personaje{
        public string Name { get; set;}
        public string Category { get; set;}
        public int Health { get; set;}
        public List<Item> Items { get; set; }

        public Personaje(string name, string category, int health){
            Name = name;
            Health = health;
            Category = category;
            Items = new List<Item>();
        }

        public abstract int CalculateTotalAttack();
        public abstract int CalculateTotalDefense();
        public abstract void Attack(Personaje target, int damage);
        public abstract void Heal();



    }
}