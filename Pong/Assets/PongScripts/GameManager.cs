using UnityEngine;
using System.Collections;

public class GameManager : getScore {

   public GUISkin theSkin;
   Transform theBall;

   void Start()
   {
       theBall = GameObject.FindGameObjectWithTag("Ball").transform;
   }


     void OnGUI()
     {
         GUI.skin = theSkin;
         GUI.Label(new Rect(Screen.width / 2 - 150-18, 20, 100, 100), "" + playerScore01);
         GUI.Label(new Rect(Screen.width / 2 + 150-18, 20, 100, 100), "" + playerScore02);

         if (GUI.Button(new Rect(Screen.width / 2-121/4, 35, 121, 53), "RESET"))
         {
             playerScore01 = 0;
             playerScore02 = 0;

             theBall.gameObject.SendMessage("ResetBall");
         }
     }

     void pauseGame()
     {
         //pauses the game
         Time.timeScale = 0.0f;
     }


}



