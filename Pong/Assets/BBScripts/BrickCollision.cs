using UnityEngine;
using System.Collections;

public class BrickCollision: MonoBehaviour
{

    public int hitsToKill;
    public int points;
    private int numberOfHits;
    public GameObject[] bricks;
    private GameObject brickSelect;
    private GameObject bluebrick = GameObject.FindGameObjectWithTag("BlueBrick");
    private GameObject goldbrick = GameObject.FindGameObjectWithTag("GoldBrick");
    private GameObject graybrick = GameObject.FindGameObjectWithTag("GrayBrick");
    private GameObject orangebrick = GameObject.FindGameObjectWithTag("OrangeBrick");

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
            numberOfHits++;

            if (numberOfHits == hitsToKill)
            {
                //get reference of player object
                GameObject player = GameObject.FindGameObjectWithTag("PlayerBB");

                // send message
                player.SendMessage("addPoints", points);

                // destroy this object
                Destroy(this.gameObject);
            }
        }
    }

}
