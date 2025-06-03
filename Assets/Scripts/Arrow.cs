using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Bullet
{
    public Arrow(float velocity) : base(velocity){}
    

    public override void Shoot()
    {
        Debug.Log($"{GetType().Name} is shot at velocity {velocity}");              
    }
}
