using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Program{
    public abstract class Personaje{
        public string Name { get; set;}
        public string Category { get; set;}
        public int Initial_health { get; set;}
        public int Current_health { get; set;}
        public List<Item> Items { get; set; }

        public Personaje(string name, string category, int initial_health, int current_health){
            Name = name;
            Initial_health = initial_health;
            Current_health = current_health;
            Category = category;
            Items = new List<Item>();
        }

        public abstract int CalculateTotalAttack();
        public abstract int CalculateTotalDefense();
        public abstract void Attack(Personaje target, int damage);
        public abstract void Heal(Personaje target);



    }
}