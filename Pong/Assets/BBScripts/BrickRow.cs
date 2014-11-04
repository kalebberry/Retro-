using UnityEngine;
using System.Collections;

public class BrickRow : BrickCollision {

    private const int SIZE = 10;
    protected GameObject[] rowBricks = new GameObject[SIZE];
    private float horizontalSpace = -8f;
    public float verticalSpace = 0f;

	// Use this for initialization
	void Start () 
    {
        RowofBricks();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    // This function will display a public array of bricks.
    void RowofBricks()
    {
      
        //Loop for the entire array
        for (int i = 0; i < SIZE; i++)
        {
            // Create the gameobject
            rowBricks[i] = RandomBrick(rowBricks[1]);
 
            // poistion ait in the scence
            rowBricks[i].transform.position = new Vector2(horizontalSpace,verticalSpace);
            horizontalSpace = horizontalSpace + 1.8f;
            
        }

    }

    GameObject RandomBrick(GameObject brick)
    {
        // Random Number 0-3
        float selector = 0;
        selector = Random.Range(0, 4);


        // Create look up table
        if (selector == 0)
        {
           brick = GameObject.Instantiate(Resources.Load("GrayBlock")) as GameObject;
        }
        else if (selector == 1)
        {
            brick = GameObject.Instantiate(Resources.Load("BlueBlock")) as GameObject;
        }
        else if (selector == 2)
        {
            brick = GameObject.Instantiate(Resources.Load("GoldBlock")) as GameObject;
        }
        else if (selector == 3)
        {
            brick = GameObject.Instantiate(Resources.Load("OrangeBlock")) as GameObject;
        }
        else
        {
            Debug.Log("No Brick Selected");
        }

        return brick;
    }
}
