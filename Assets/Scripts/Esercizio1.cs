using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Arrow arrow1 = new Arrow(5);
        MagicBall magicball1 = new MagicBall(3);
        Arrow arrow2 = new Arrow(7);
        MagicBall magicball2 = new MagicBall(2);

        arrow1.Shoot();
        arrow2.Shoot();
        magicball1.Shoot();
        magicball2.Shoot(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
