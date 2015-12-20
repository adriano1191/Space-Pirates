using UnityEngine;
using System.Collections;

public class Move_Buttons : MonoBehaviour {


    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector3 touchPosition = Input.GetTouch(0).position;

            //Check if it is left or right?
            if (touchPosition.x < 0.0f)
            {
                player.transform.Translate(Vector3.left * 10 * Time.deltaTime);
            }
            else if (touchPosition.x > 0.0f)
            {
                player.transform.Translate(Vector3.right * 10 * Time.deltaTime);
            }

        }
    }
}
