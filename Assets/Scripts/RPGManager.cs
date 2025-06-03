using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGManager : MonoBehaviour
{
    

    void Start()
    {
        int amount = Random.Range(1, 21);

        Warrior warrior = new Warrior("Aragorn", 100);
        Archer archer = new Archer("Legolas", 80);
        Mage mage = new Mage("Gandalf", 60);

        warrior.Attack();
        warrior.TakeDamage(amount);
        archer.Attack();
        archer.TakeDamage(amount);
        mage.Attack();
        mage.TakeDamage(amount);
    }


}
