using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
  public string Name 
  { 
   get;
   set; 
   }
    private int health;
    public int Health
    {
    get { return health; }
    set { health = (value > 100) ? 100 : value; } 
    }

    public Character(string name, int health)
    {
    Name = name;
    Health = health;
}
} 



