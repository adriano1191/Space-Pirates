using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Health_Bar : MonoBehaviour {
    private Text someText;
    void Start()
    {
        someText = GetComponent<Text>();
    }

    void Update()
    {
        //Stats_Player hp = GameObject.Find("Player").GetComponent<Stats_Player>();
        if (GameObject.Find("Player") != null)
        {
            Stats_Player hp = GameObject.Find("Player").GetComponent<Stats_Player>();
            someText.text = "HP: " + hp.health.ToString();
        }
        else
        {
            someText.text = "HP: 0";
        }
    }
    
}
