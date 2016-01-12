using UnityEngine;
using System.Collections;

public class Stats_Player : MonoBehaviour {


    public int health;
    int highscore;
    int coins;

    void Start()
    {

        health = PlayerPrefs.GetInt("Health"); // handles case it doesn't exist and provides a default value of zero unless otherwise specified

    }


    public void Heal(int addHeal)
    {
        health += addHeal;
        PlayerPrefs.SetInt("Health", health); //Save Highscore OnDisable 
        PlayerPrefs.Save();
    }


    public void Damage(int damageCount)
    {
        health -= damageCount;
        

        if (health <= 0)
        {
            // Dead!
            Destroy(gameObject);
            Game_Over.instace.death = true;
            Game_Over.instace.pause = true;

        }

    }

    //dostęp do zmiennej statycznej
    /*
     public static Stats_Player instace;
     void Start()
     {
    instace = this;
     }*/

}
