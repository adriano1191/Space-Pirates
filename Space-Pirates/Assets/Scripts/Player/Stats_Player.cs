using UnityEngine;
using System.Collections;

public class Stats_Player : MonoBehaviour {


    public int health = 2;

    public void Damage(int damageCount)
    {
        health -= damageCount;

        if (health <= 0)
        {
            // Dead!
            Destroy(gameObject);
            Game_Over.instace.death = true;
            Game_Over.instace.pause = true;

        }

    }


    //dostęp do zmiennej statycznej
    /*
     public static Stats_Player instace;
     void Start()
     {
    instace = this;
     }*/

}
