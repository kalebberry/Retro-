using UnityEngine;
using System.Collections;

public class getScore : MonoBehaviour {

	// Use this for initialization
    public static getScore instance { get; private set; }
    protected int playerScore01 = 0;
    protected int playerScore02 = 0;

	void Awake () 
    {
        instance = this;
	}
	
	// Update is called once per frame
    public void score(string wallName)
    {
        if (wallName == "rightWall")
        {
            playerScore01++;

            if (playerScore01 == 7)
            {
                gameOver();
            }
        }
        else if(wallName == "leftWall")
        {
            playerScore02++;

            if (playerScore02 == 7)
            {
                gameOver();
            }
        }
        Debug.Log("Player Score 1 is " + playerScore01);
        Debug.Log("Player Score 2 is " + playerScore02);
    }

    void gameOver()
    {
        //pauses the game
        Time.timeScale = 0.0f;
    }
 
}
