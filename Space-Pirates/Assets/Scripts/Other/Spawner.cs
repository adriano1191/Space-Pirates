using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public int howmany = 1;
    private int x = 1;
    public float spawnRate = 0.25f;
    private float spawnCooldown;
    public Transform spawn;
    GameObject spawner;



    void Start()
    {
        spawnCooldown = 0f;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        spawnCooldown += Time.deltaTime;
        if (spawnCooldown > spawnRate && x <= howmany )
        {

            Instantiate(spawn, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            //shoot.transform.position = new Vector2(20, 20);
            x++;
            spawnCooldown = 0f;
        }
    }
}
