using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string name;
    public int hp;

    public abstract void Attack();
    public abstract void TakeDamage(int damage);    

    public Character(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }
}
