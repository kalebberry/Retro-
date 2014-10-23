using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 10.0f;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    Collision2D collider;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            rigidbody2D.AddForce(new Vector2(0, 50));
        }
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
