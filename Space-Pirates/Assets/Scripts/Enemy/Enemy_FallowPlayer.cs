using UnityEngine;
using System.Collections;

public class Enemy_FallowPlayer : MonoBehaviour {
    //Przeciwnik zmierza w strone gracza


    public float fallowSpeed = 1f;
    private Vector2 playerVector;
    public Vector2 speed = new Vector2(10, 10);
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;
    Rigidbody2D rigid;
    private Vector2 player;
    private Vector2 enemy;
    


    void Start () {
        rigid = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform.position;
        }
        enemy = gameObject.transform.position;


        if (player.y > enemy.y)
        {
            movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y + fallowSpeed);
        }
        if (player.y < enemy.y)
        {
            movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y - fallowSpeed);
        }
        if (player.y == enemy.y)
        {
            movement = new Vector2(
      speed.x * direction.x,
      speed.y * direction.y);
        }

    }

    void FixedUpdate()
    {

        rigid.velocity = movement;
    }
}
