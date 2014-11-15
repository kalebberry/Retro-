using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

    void Update()
    {
         Screen.SetResolution(800, 480, false);
    }
    void OnGUI()
    {
        const int buttonWidth = 88;
        const int buttonHeight = 25;
        const int buttonBreakWidth = 100;

        // Determine the button's place on the screen
        // Center in X, 2/3 of the height in Y
        
        /*
        Rect buttonPong = new Rect(Screen.width / 2 - (buttonWidth / 2),
           (2 * Screen.height / 3) - (buttonHeight / 14), buttonWidth,
            buttonHeight);
         */
       /*
        Rect buttonBreak = new Rect(Screen.width / 4 - (buttonBreakWidth / 4),
            (2 * Screen.height / 3) - (buttonHeight / 14), buttonBreakWidth,
            buttonHeight);
        */

        Rect buttonPong = new Rect(-200, 30, 88, 25);
        Rect buttonBreak = new Rect(-150, 30, 88, 25);

        // Draw a button to Pong
        if (GUI.Button(buttonPong, "Play Pong"))
        {
            // On Click, load the first level
            // Level1_Pong is the ame of the first scence we created.
            Application.LoadLevel("Level1_Pong");
        }

        // Draw a button to Pong
        if (GUI.Button(buttonBreak, "Play Breakout"))
        {
            // On Click, load the first level
            // Level1_Pong is the ame of the first scence we created.
            Application.LoadLevel("BrickBreak");
        }
    }

}
    