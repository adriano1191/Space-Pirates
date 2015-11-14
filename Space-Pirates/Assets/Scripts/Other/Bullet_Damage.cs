using UnityEngine;
using System.Collections;

public class Bullet_Damage : MonoBehaviour
{
    public int damage = 1;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag =="Enemy")
        {
            col.gameObject.GetComponent<Stats_Enemy>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
