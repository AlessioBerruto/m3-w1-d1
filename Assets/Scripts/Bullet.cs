using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet
{
    public float velocity;

    public Bullet(float velocity) {  this.velocity = velocity; }

    public abstract void Shoot();
}
