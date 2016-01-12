using UnityEngine;
using System.Collections;

public class Moneta : MonoBehaviour {
    public int cointAdd = 1;

    void OnCollisionEnter2D(Collision2D coin)

    {

        if (coin.gameObject.name == "Player")
        {
            //Destroy(col.gameObject);
            //Stats_Player.instace.health -= damage;
            //Stats_Player.instace.Damage(damage);

            coin.gameObject.GetComponent<Stats_Player>().Heal(cointAdd);
            //this.gameObject.GetComponent<Stats_Enemy>().Damage(damage);
            Destroy(gameObject);

        }
    }
}
