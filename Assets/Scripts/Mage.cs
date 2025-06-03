using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public Mage(string name, int hp) : base(name, hp) { }

    public override void Attack()
    {
        Debug.Log($"{name} has {hp} HP");
        Debug.Log($"{name} casts a spell!");
        Debug.Log("The spell inflicts 12 damage!");
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log($"{name} takes {damage} damage!");
        hp += -damage;
        Debug.Log($"{name} has {hp} HP left!");
    }
}
