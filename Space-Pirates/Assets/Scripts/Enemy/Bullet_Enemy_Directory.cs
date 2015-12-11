using UnityEngine;
using System.Collections;

public class Bullet_Enemy_Directory : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 1);
    public Vector2 direction = new Vector2(1, 0);
    public float rangeTime = 3.5f;
    public float time;
    public float erection = 250.0f;
    public float mass = 10.0f;
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
        erection -= mass;
        rigid.AddForce(new Vector2(0, erection), ForceMode2D.Force);
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        rigid.velocity = movement;
        if (time >= rangeTime)
        {

            Destroy(gameObject);
            time = 0f;
        }
    }
}
