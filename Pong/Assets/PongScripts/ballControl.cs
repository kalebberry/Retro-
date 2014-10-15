using UnityEngine;
using System.Collections;

public class ballControl : MonoBehaviour {

    public float ballSpeed = 100;

	// Use this for initialization
	void Start() {
        StartCoroutine(WaitStart());
	}

    void Update()
    {
        float xVel = rigidbody2D.velocity.x;
        Debug.Log("Velocity" + xVel);
        if (xVel < 18 && xVel > -18 && xVel != 0)
        {
            if (xVel > 0)
            {
                rigidbody2D.velocity = new Vector2(20, 0);
            }
            else
            {
                rigidbody2D.velocity = new Vector2(-20, 0);
            }
        }
        Debug.Log("Velocity Before " + xVel);
        Debug.Log("Velocity Before " + rigidbody2D.velocity.x);
    }

   public void ResetBall()
    {
        rigidbody2D.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 1);

        StartCoroutine(WaitReset());

    }

    void GoBall()
    {
       
        float randomNumber = Random.Range(0, 2f); // needs to be 2
        if (randomNumber <= 0.5)
        {
            rigidbody2D.AddForce(new Vector2(ballSpeed, 10));
            Debug.Log("shoot Right");
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(-ballSpeed, -10));
            Debug.Log("shoot Left");
        }
    }
	
	// called once per frame automactally 
	void OnCollisionEnter2D (Collision2D collInfo) {
        if (collInfo.collider.tag == "Player")
        {
            Debug.Log("ITS WORKING!");
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y/2 + collInfo.collider.rigidbody2D.velocity.y/3 );	﻿
            audio.pitch = Random.Range(0.8f, 1.2f);
            audio.Play();
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
