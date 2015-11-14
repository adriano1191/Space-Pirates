using UnityEngine;
using System.Collections;

public class Damage_Collision_Enemy : MonoBehaviour {

    public int damage = 1;

    void OnCollisionEnter2D(Collision2D col)

    {
       
        if (col.gameObject.name == "Player")
        {
            //Destroy(col.gameObject);
            //Stats_Player.instace.health -= damage;
            //Stats_Player.instace.Damage(damage);

            col.gameObject.GetComponent<Stats_Player>().Damage(damage);
            //this.gameObject.GetComponent<Stats_Enemy>().Damage(damage);
            Destroy(gameObject);

        }
    }
}
