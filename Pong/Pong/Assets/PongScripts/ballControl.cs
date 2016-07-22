using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {

    public float ballSpeed = 25;
    private bool DEBUG = false;

	// Use this for initialization
	void Start() {
        StartCoroutine(WaitStart());
	}

    void FixedUpdate()
    {
        float xVel = GetComponent<Rigidbody2D>().velocity.x;

        if (DEBUG)
        {
            Debug.Log("Velocity" + xVel);

        }
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {
            if (xVel > 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(20, 0);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-20, 0);
            }
        }

        if (DEBUG)
        {

           Debug.Log("Velocity Before " + xVel);
           Debug.Log("Velocity Before " + GetComponent<Rigidbody2D>().velocity.x);
        }
    }

    public void ResetBall()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 1);
        
        StartCoroutine(WaitReset());
    }

    void GoBall()
    {
       
        float randomNumber = Random.Range(0, 2f); // needs to be 2
        if (randomNumber <= 0.5)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed, 10));

            if (DEBUG)
            {
                Debug.Log("shoot Right");
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballSpeed, -10));

            if (DEBUG)
            {
                Debug.Log("shoot Left");
            }
        }
    }
	
	// called once per frame automactally 
	void OnCollisionEnter2D (Collision2D collInfo) {
        if (collInfo.collider.tag == "Player")
        {
            if (DEBUG)
            {
                Debug.Log("ITS WORKING!");
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y/2 + collInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3 );	﻿
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            GetComponent<AudioSource>().Play();
        }
	
	}

    // This function waits 5 Seconds before starting the game
    IEnumerator WaitStart() 
    {
        yield return new WaitForSeconds(2);
        GoBall();
    }

    IEnumerator WaitReset()
    {
        yield return new WaitForSeconds(2);
        GoBall();
    }
}
