using UnityEngine;
using System.Collections;

public class Camera_Move : MonoBehaviour {

    public Vector2 speed = new Vector2(5, 5);
    public Vector2 direction = new Vector2(1, 0);
    private Vector2 movement;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        movement = new Vector2(
  speed.x * direction.x,
  speed.y * direction.y);
    }

    void FixedUpdate()
    {

        rigid.velocity = movement;
    }
}
