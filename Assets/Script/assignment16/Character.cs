using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16
{
    public class Character
    {
        public string Name { get; set; }
        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set => health = Mathf.Clamp(value, 0, 100); 
        }


        public Character(string name, int health, Position position)
        {
            Name = name;
            Health = health;
            this.position = position;
        }


        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name: {Name}, Health: {Health}");
            position.PrintPosition();
        }


        public void Attack(int damage, Character target)
        {
            target.Health -= damage;
            Debug.Log("{Name} attacked {target.Name} and dealt {damage} damage.");
        }

        public void Attack(int damage, Character target, string attackType)
        {
            Attack(damage, target); 
            Debug.Log("Attack Type: {attackType}");
        }
    }
}
