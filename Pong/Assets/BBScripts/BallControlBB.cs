using UnityEngine;
using System.Collections;

public class BallControlBB : MonoBehaviour 
{

    public float ballSpeed = 10f;
    public Transform ball;
    private Vector2 ballPosition;
    private Vector2 ballInitialForce;
    private bool ballIsActive;
    float direct = 0;

    public GameObject playerObject;



	// Use this for initialization
	void Start () 
    {
        direction();
        ballInitialForce = new Vector2(direct, 300.0f);

        // Set to inactive
        ballIsActive = false;

        // ballposition
        ballPosition = transform.position;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") == true)
        {
            // Check if is the first play
            if (!ballIsActive)
            {

                // resets force
                rigidbody2D.isKinematic = false;

                // add a force
                rigidbody2D.AddForce(ballInitialForce);

                // Set ball to actice
                ballIsActive = true;
            }
        }

        if (!ballIsActive && playerObject != null)
        {
            // get and use the player position
            ballPosition.x = playerObject.transform.position.x;

            // apply the player X position to the ball
            transform.position = ballPosition;
        }

        // Check if ball fails
        if (ballIsActive && transform.position.y < -3.9)
        {
            ballIsActive = false;
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = -3.6f;
            transform.position = ballPosition;

            rigidbody2D.isKinematic = true;

            // Send Message
            playerObject.SendMessage("TakeLife");
        }

    }

    void direction() 
    {
         float ran = Random.Range(0,2);

        if (ran == 0)
        {
            direct = 100.0f;
        }
        else
        {
            direct = 50.0f;
        }
        
    }


     
}
