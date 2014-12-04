using UnityEngine;
using System.Collections;

public class OverMenu : getScore
{
    public GUISkin theSkins;

    // Update is called once per frame
    public void OnGUI()
    {
        GUI.skin = theSkins;
        if (player1wins)
        {

            GUI.Label(new Rect(Screen.width / 2 - 84, Screen.height / 2 - 60, 100, 30), "Player1 Wins!!");
            GUI.Label(new Rect(Screen.width / 2 - 84, Screen.height / 2 - 40, 100, 30), "Player1: " + roundWins2 + "-" + "Player2: " + roundWins1);
        }
        else
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 70, 100, 30), "Player2 Wins!!");
            GUI.Label(new Rect(Screen.width / 2 - 94 , Screen.height / 2 - 40, 100, 30), "Player2: " + roundWins2 + "   -   " + "Player 1: " + roundWins1);
        }


        if (GUI.Button(new Rect(Screen.width / 2 - 140, Screen.height / 2 - -20, 100, 30), "Play Again"))
        {
           
            Application.LoadLevel("Level1_Pong");
            Debug.Log("The button was pressed!");

        }
        if (GUI.Button(new Rect(Screen.width / 2 - (-10), Screen.height / 2 - -20, 100, 30), "Main Menu"))
        {

            Debug.Log("The button was pressed!");
            Application.LoadLevel("GameMenu");
        }

    }
}
