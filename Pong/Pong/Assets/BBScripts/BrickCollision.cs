using UnityEngine;
using System.Collections;

public class BrickCollision: MonoBehaviour
{

    public int hitsToKill;
    public int points;
    protected int increase;
    protected int numberOfHits;
    public GameObject[] bricks;
    private GameObject brickSelect;
    SpriteRenderer renderer;
    Rigidbody clone;


	// Use this for initialization
	void Start () 
    {
        
        numberOfHits = 0;
  
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            GetComponent<AudioSource>().Play();
            numberOfHits++;

            if (numberOfHits == hitsToKill)
            {
                //get reference of player object
                GameObject player = GameObject.FindGameObjectWithTag("PlayerBB");

                // send message
                player.SendMessage("addPoints", points);

                // Increase Level Counter
                player.SendMessage("increaseLevel");
               
               
                // destroy this object
                Destroy(this.gameObject,0.1f);
            }
            else
            {
                changeColor(this.gameObject);
            }
        }
    }

    void changeColor(GameObject brick)
    {
        //Color color = brick.transform.renderer.material.color;
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Color color = sr.color;
        Color ORANGE = new Color(0.934f, 0.409f, 0.124f, 1.00f);
        Color GOLD = new Color(1.000f, 0.929f, 0.037f, 1.000f);
        Color BLUE = new Color(0.026f, 0.396f, 0.893f, 1.000f);
        if (color.ToString().Equals(ORANGE.ToString()))
        {
            sr.color = GOLD;
        }
        else if (color.ToString().Equals(GOLD.ToString()))
        {
            sr.color = BLUE;
        }
        else if (color.ToString().Equals(BLUE.ToString()))
        {
            sr.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    IEnumerator wait()
    {
        print(Time.time);
        yield return new WaitForSeconds(100f);
        print(Time.time);
    }



}
