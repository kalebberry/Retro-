using UnityEngine;
using System.Collections;

public class GameSetupBB : MonoBehaviour {

    public Camera mainCam;

    public BoxCollider2D topWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;
    public BoxCollider2D bottomWall;

    public Transform player01;


    void Start()
    {
        player01.position = new Vector3(0f, -3.8f, 0f);
    }
	// Update is called once per frame
	void Update () 
    {
        //Move each wall to its edge location:
        topWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f,0f)).x,1f);
        topWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.center = new Vector2(0f, mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height*2f, 0f)).y);
        leftWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f,Screen.height * 2f,0f)).y);
        rightWall.center = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width,0f, 0f)).x + 0.5f,0f);

        //player01.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(2f, 0f, 0f)).x, player01.position.y, player01.position.z);
	}
}
