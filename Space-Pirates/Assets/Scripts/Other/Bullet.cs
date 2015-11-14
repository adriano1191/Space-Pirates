using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(1, 0);
    public float rangeTime = 1.5f;
    public float time;
    private Vector2 movement;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        time = 0f;

    }


    void Update()
    {
        movement = new Vector2(
  speed.x * direction.x,
  speed.y * direction.y);
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        rigid.velocity = movement;
        if(time >= rangeTime)
        {

            Destroy(gameObject);
            time = 0f;
        }
    }
}
