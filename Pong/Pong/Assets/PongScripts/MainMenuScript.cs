using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public GUISkin theSkins;
    private bool showMenu1 = true;
    private bool showMenu2 = false;

    // Update is called once per frame
    public void OnGUI()
    {

        GUI.skin = theSkins;

        if (showMenu1)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 60, 160, 40), "Games"))
            {
                Debug.Log("The button was pressed!");
                GetComponent<AudioSource>().Play();
                showMenu1 = false;
                showMenu2 = true;  
             }

            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 20, 160, 40), "Exit"))
            {

                Debug.Log("The button was pressed!");
                Application.Quit();
            }

         }

        if (showMenu2)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 60, 170, 40), "PongIsLife"))
            {
                GetComponent<AudioSource>().Play();
                Application.LoadLevel("Level1_Pong");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - 20, 175, 40), "SSBreakout"))
            {

                Debug.Log("The button was pressed!");
                GetComponent<AudioSource>().Play();
                Application.LoadLevel("BrickBreak");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 330, Screen.height / 2 - -20, 160, 40), "Back"))
            {

                Debug.Log("The button was pressed!");
                GetComponent<AudioSource>().Play();
                showMenu2 = false;
                showMenu1 = true;
            }

        }

        }

    }
