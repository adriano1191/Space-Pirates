using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float moveSpeed = 2f;
    public Vector2 speed = new Vector2(10, 10);
    Rigidbody2D rigid;
    private Vector2 playerPosition;
    private Vector3 kamera;
    public float poss;
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



        if (GameObject.FindGameObjectWithTag("MainCamera") != null)
        {
            kamera = GameObject.FindGameObjectWithTag("MainCamera").transform.position;
        }


        ///Poiebera wielkosc kamery x==0 to lewa krawedz kamery a x==1 to prawa krawedz
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.07f, 0.93f);
        pos.y = Mathf.Clamp(pos.y, 0.07f, 0.93f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        poss = pos.x;
        playerPosition = gameObject.transform.position;

        //ograniczenie Y
       /* if(pos.y == 0.07f)
        {
            //transform.position = new Vector2(transform.position.x, kamera.y + -4.4f);

           // pos.x = Mathf.Clamp(pos.x, 0.07f, 0.93f);
           // pos.y = Mathf.Clamp(pos.y, 0.07f, 0.07f);
          //  transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
        if (playerPosition.y >= Camera.main.transform.position.y + 4.1f)
        {
            transform.position = new Vector2(transform.position.x, Camera.main.transform.position.y + 4.1f);
        }



        //ograniczenie X
        if (playerPosition.x <= kamera.x + -7.8f)
        {
            transform.position = new Vector2(kamera.x + -7.8f, transform.position.y);
        }
        if (playerPosition.x >= kamera.x + 7.7f)
        {
            transform.position = new Vector2(kamera.x + 7.7f, transform.position.y);
        }*/

        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

    }

    void FixedUpdate()
    {
        // 5 - Move the game object
        rigid.velocity = movement;
        //rigidbody2D.velocity = movement;
    }
}
