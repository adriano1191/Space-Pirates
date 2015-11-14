using UnityEngine;

/// <summary>
/// Start or quit the game
/// </summary>
public class Game_Over : MonoBehaviour
{
    public static Game_Over instace;
    public bool death = false;
    public bool pause = false;
    void Start()
    {
        instace = this;
    }

    void Update()
    {

        if (Input.GetKeyDown("escape") && pause == false && death == false)
        {
            pause = true;
        }
        else if(Input.GetKeyDown("escape") && pause == true && death == false)
        {
            pause = false;
        }

        if(pause == true)
        {
            Time.timeScale = 0.0f;
        }
        if (pause == false)
        {
            Time.timeScale = 1.0f;
        }

    }
    

    void OnGUI()
        
    {
        if (pause == true) {
            
            const int buttonWidth = 120;
        const int buttonHeight = 60;

        if (
          GUI.Button(
            // Center in X, 1/3 of the height in Y
            
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Retry!"

          )
        )
        {
                // Reload the level
                Application.LoadLevel("Testowa");
        }

        if (
          GUI.Button(
            // Center in X, 2/3 of the height in Y
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (2 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Back to menu"
          )
        )
        {
                // Reload the level
                pause = false;
            Application.LoadLevel("Menu");
        }
    }
    }

}