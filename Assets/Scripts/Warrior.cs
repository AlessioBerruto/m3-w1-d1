using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character
{
    public Warrior(string name, int hp) : base(name, hp) { }

    public override void Attack()
    {
        Debug.Log($"{name} has {hp} HP");
        Debug.Log($"{name} swings a mighty sword!");
        Debug.Log("The sword inflicts 10 damage!");
    }

    public override void TakeDamage(int damage)
    {

        Debug.Log($"{name} takes {damage} damage!");
        hp += -damage;
        Debug.Log($"{name} has {hp} HP left!");
    }

}
