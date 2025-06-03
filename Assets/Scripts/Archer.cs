using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Character
{
    public Archer(string name, int hp) : base(name, hp) { }

    public override void Attack()
    {
        Debug.Log($"{name} has {hp} HP");
        Debug.Log($"{name} shoots the first arrow!");
        Debug.Log("The arrow inflicts 7 damage!");
        Debug.Log($"{name} shoots the second arrow!");
        Debug.Log("The arrow inflicts 7 damage!");
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log($"{name} takes {damage} damage!");
        hp += -damage;
        Debug.Log($"{name} has {hp} HP left!");
    }
}
