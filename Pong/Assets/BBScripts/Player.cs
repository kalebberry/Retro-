using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 10.0f;
    public KeyCode moveLeft;
    public KeyCode moveRight;

	
	// Update is called once per frame
	void Update () 
    {
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
        
	
	}
}
