using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

   int playerScore01 = 0;
   int playerScore02 = 0;
   public GUISkin theSkin;
   Transform theBall;

   void Start()
   {
       theBall = GameObject.FindGameObjectWithTag("Ball").transform;
   }

	// Update is called once per frame
	 public void score (string wallName)
     {
         if (wallName == "rightWall")
         {
             playerScore01++;
         }
         else
         {
             playerScore02++;
         }
         Debug.Log("Player Score 1 is " + playerScore01);
         Debug.Log("Player Score 2 is " + playerScore02);
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

     void gameOver()
     {
         //pauses the game
         Time.timeScale = 0.0f;
     }


}



