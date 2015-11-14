using UnityEngine;
using System.Collections;

public class Shooting_Player : MonoBehaviour {

    public float shootingRate = 0.25f;
    public float shootCooldown;
    public Transform bullet;


    void Start () {
        shootCooldown = 0f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        shootCooldown += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && shootCooldown > shootingRate)
        {

            Instantiate(bullet, transform.position, Quaternion.identity);
            shootCooldown = 0f;
        }
    }
}
