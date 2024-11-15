using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }

    public void Attack(Character target, int amount)
    {
        target.Health -= amount;
        System.Console.WriteLine($"{Name} attacked {target.Name}, reducing their health to {target.Health} HP.");
    }


}

