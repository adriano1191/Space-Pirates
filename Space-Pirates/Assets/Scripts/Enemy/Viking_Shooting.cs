using UnityEngine;
using System.Collections;

public class Viking_Shooting : MonoBehaviour {
    public float shootingRate = 0.25f;
    public float shootCooldown;
    public Transform bullet_Left;
    public Transform bullet_Center;
    public Transform bullet_Right;
    GameObject shoot;
    Vector2 movePosition = new Vector2(1f, 1f);
    float speed = 5f;


    void Start()
    {
        shootCooldown = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        shootCooldown += Time.deltaTime;
        if (shootCooldown > shootingRate)
        {

            Instantiate(bullet_Left, new Vector2(transform.position.x + -0.75f, transform.position.y + -1.25f), Quaternion.identity);
            Instantiate(bullet_Center, new Vector2(transform.position.x + 0f, transform.position.y + -1.25f), Quaternion.identity);
            Instantiate(bullet_Right, new Vector2(transform.position.x + 0.72f, transform.position.y + -1.25f), Quaternion.identity);


            shootCooldown = 0f;
        }
    }
}
