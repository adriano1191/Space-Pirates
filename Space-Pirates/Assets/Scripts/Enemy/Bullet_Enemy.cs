using UnityEngine;
using System.Collections;

public class Bullet_Enemy : MonoBehaviour {

    public int damage = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<Stats_Player>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
