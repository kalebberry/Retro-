using UnityEngine;
using System.Collections;

public class BallControlBB : MonoBehaviour {

    public bool grounded = false; // Check if player has press spacebar to start the game
    public bool interact = false;
    public float ballSpeed = 50f;
    public Transform ball;

    RaycastHit2D whatIHit;

	// Use this for initialization
	void Start () {

        ball.position = new Vector3(0f, -3.0f, 0f);
        
	}
	
	// Update is called once per frame
	void Update () {
	 

	}

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "PlayerBB")
        {
            rigidbody2D.AddForce(new Vector2(ballSpeed, 300));
            Debug.Log("Paddle Hit");
           
        }
    }

}
