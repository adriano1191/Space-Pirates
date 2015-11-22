using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveSpeed = 2f;
    public Vector2 speed = new Vector2(10, 10);
    Rigidbody2D rigid;
    private Vector2 playerPosition;


    void Start () {


        rigid = GetComponent<Rigidbody2D>();

    }



    private Vector2 movement;

    public Vector3 direction { get; internal set; }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

        //gracz nie moze wyjsc poza obszar kamery
        playerPosition = gameObject.transform.position;
        if(playerPosition.y <= -4.4f)
        {
            transform.position = new Vector2(transform.position.x, -4.4f);
        }
        if (playerPosition.y >= 4.1f)
        {
            transform.position = new Vector2(transform.position.x, 4.1f);
        }
        if (playerPosition.x <= -7.8f)
        {
            transform.position = new Vector2(-7.8f, transform.position.y);
        }
        if (playerPosition.x >= 7.7f)
        {
            transform.position = new Vector2(7.7f, transform.position.y);
        }

        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");
        // Careful: For Mac users, ctrl + arrow is a bad idea

    }

    void FixedUpdate()
    {
        // 5 - Move the game object
        rigid.velocity = movement;
        //rigidbody2D.velocity = movement;
    }
}
