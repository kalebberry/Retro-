using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
     public KeyCode moveUp; // events
     public KeyCode moveDown;

     public float speed = 10.0f;

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        }	


	}
}
