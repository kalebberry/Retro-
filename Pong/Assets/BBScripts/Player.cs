using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 10.0f;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    private int playerLives;
    private int playerPoints;


    void Start()
    {
        playerLives = 3;
        playerPoints = 0;
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

    }

    void TakeLife()
    {
        playerLives--;
    }

	// Update is called once per frame
	void Update () 
    {
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
	}
}
