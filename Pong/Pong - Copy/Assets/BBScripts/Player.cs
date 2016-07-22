using UnityEngine;
using System.Collections;

public class Player : BrickCollision {

    public float speed = 10.0f;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    private int playerLives;
    private int playerPoints;
    private Transform paddle;
    private GameObject bricksRowClone;
    private float lockPos = 0;
    protected int level = 1;
    private bool showedGUI = false;
    private bool showGUI = false;
    public int gonextLevel = 30;
    protected int levelCounter;
    private bool pauseDisabled = true;
    private bool pauseGame = false;
    private bool playerwins = false;



    void Start()
    {
        playerLives = 3;
        playerPoints = 0;
    }

    void nextLevel()
    {

        if (levelCounter == gonextLevel)
        {
            bricksRowClone = GameObject.Instantiate(Resources.Load("RowofBricksTop")) as GameObject;
            bricksRowClone = GameObject.Instantiate(Resources.Load("RowofBricksMid")) as GameObject;
            bricksRowClone = GameObject.Instantiate(Resources.Load("RowofBricksLow")) as GameObject;
            level++;
            playerLives++;
            levelCounter = 0;
        }
    }

    void increaseLevel()
    {
        levelCounter++;
        Debug.Log("Level Counter: " + levelCounter);
    }

    void addPoints(int points)
    {
        playerPoints += points;
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            rigidbody2D.AddForce(new Vector2(0, 50));
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(5.0f, 4.0f, 200.0f, 200.0f), "Live's: " + playerLives);
        GUI.Label(new Rect(5.0f, 16.0f, 200.0f, 200.0f),  "Score: " + playerPoints);
        GUI.Label(new Rect(5.0f, 28.0f, 200.0f, 200.0f),  "Level: " + level);

    }

    void TakeLife()
    {
        playerLives--;

        if (playerLives == 0)
        {
            // Game Over, Display user's Score
            Time.timeScale = 0;
            showGUI = true;
            if (showGUI)
            {
                // Display GUI
                playerwins = true;
                GameObject.Find("GameOverText").guiText.enabled = true;
                GameObject.Find("Score").guiText.text = "Your Score is: " + playerPoints;
                GameObject.Find("Score").guiText.enabled = true;
                GameObject.Find("ResetGO").guiText.enabled = true;
                GameObject.Find("backMMGO").guiText.enabled = true;
                GameObject.Find("GameOverBG2").guiTexture.enabled = true;
            }

        }
    }

	// Update is called once per frame
	void Update () 
    {
        // Pause Game
        if (pauseDisabled)
        {
            if (Input.GetKeyDown("p"))
            {
                pauseGame = !pauseGame;

                if (pauseGame == true)
                {
                    Time.timeScale = 0;
                    pauseGame = true;
                    showedGUI = true;
                }
            }
        }

        if (pauseGame == false)
        {
            Time.timeScale = 1;
            pauseGame = false;
            showedGUI = false;
        }

        if (playerwins == true)
        {
            showedGUI = false;
            pauseDisabled = false;
            pauseGame = true;
            Time.timeScale = 0;
        }

        if (showedGUI == true)
        {
            
            GameObject.Find("Reset").guiText.enabled = true;
            GameObject.Find("backMM").guiText.enabled = true;
            GameObject.Find("PausedGUI").guiTexture.enabled = true;

        }

        else
        {
           
            GameObject.Find("Reset").guiText.enabled = false;
            GameObject.Find("backMM").guiText.enabled = false;
            GameObject.Find("PausedGUI").guiTexture.enabled = false;
        }

        // next Level?
        nextLevel();
        

        //Lock rotaion of paddle
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);

        //Movement with A and D
        if (Input.GetKey(moveRight))
        {
            rigidbody2D.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(moveLeft))
        {
            rigidbody2D.velocity = new Vector2(speed * -1, 0);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown("m"))
        {
            Time.timeScale = 1;
            Application.LoadLevel("GameMenu");
        }

        if (Input.GetKeyDown("r"))
        {
            Time.timeScale = 1;
            Application.LoadLevel("BrickBreak");
        }
	}
}
