using UnityEngine;
using System.Collections;

public class Enemy_Wave_Move : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;
    Rigidbody2D rigid;
    public float waveMax = 5f;
    public float waveTick = 0.5f;
    public float wave;
    private float changeY = 1;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        wave = 0;

    }


    void Update()
    {
        movement = new Vector2(
  speed.x * direction.x,
  speed.y * direction.y * changeY);
    }

    void FixedUpdate()
    {

        wave += waveTick * changeY;
        if (wave >= waveMax)
        {
            changeY = -1;
        }
        if (wave <= 0)
        {
            changeY = 1;
        }


        rigid.velocity = movement;

    }
}
