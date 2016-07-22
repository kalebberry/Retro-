using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {
 


    void OnMouseUp()
    {
        Debug.Log("Button was Clicked");
        GameObject.Find("Games").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Exit").GetComponent<Renderer>().enabled = false;

        GameObject.Find("pongisLife").GetComponent<Renderer>().enabled = true;
        GameObject.Find("Breakout").GetComponent<Renderer>().enabled = true;
    

    }
}
