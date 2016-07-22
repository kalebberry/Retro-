using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {
 


    void OnMouseUp()
    {
        Debug.Log("Button was Clicked");
        GameObject.Find("Games").renderer.enabled = false;
        GameObject.Find("Exit").renderer.enabled = false;

        GameObject.Find("pongisLife").renderer.enabled = true;
        GameObject.Find("Breakout").renderer.enabled = true;
    

    }
}
