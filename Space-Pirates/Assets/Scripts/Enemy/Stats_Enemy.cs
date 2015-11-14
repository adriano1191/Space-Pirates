using UnityEngine;
using System.Collections;

public class Stats_Enemy : MonoBehaviour {


    public int health = 1;

    public void Damage(int damageCount)
    {
        health -= damageCount;

        if (health <= 0)
        {
            // Dead!
            Destroy(gameObject);
            
        }
    }

}
