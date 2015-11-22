﻿using UnityEngine;
using System.Collections;

public class Shooting_Player : MonoBehaviour {

    public float shootingRate = 0.25f;
    public float shootCooldown;
    public Transform bullet;
    GameObject shoot;
    Vector2 movePosition = new Vector2(1f, 1f);
    float speed = 5f;


    void Start () {
        shootCooldown = 0f;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        shootCooldown += Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && shootCooldown > shootingRate)
        {

        Instantiate(bullet, new Vector2(transform.position.x + 0.75f, transform.position.y + 0.09f), Quaternion.identity);
            //shoot.transform.position = new Vector2(20, 20);

            shootCooldown = 0f;
        }
    }
}
