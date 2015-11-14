using UnityEngine;
using System.Collections;

public class Menu_Start : MonoBehaviour {

void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        Rect buttonRect = new Rect(
          Screen.width / 2 - (buttonWidth / 2),
          (2 * Screen.height / 3) - (buttonHeight / 2),
          buttonWidth,
          buttonHeight

        );
        if (GUI.Button(buttonRect, "Start!"))
        {
            // On Click, load the first level.
            // "Stage1" is the name of the first scene we created.
            Application.LoadLevel("Testowa");
        }
    }
}
