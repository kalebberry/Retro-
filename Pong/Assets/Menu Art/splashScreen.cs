using UnityEngine;
using System.Collections;

public class splashScreen : MonoBehaviour {
    public float timer = 2f;
    public float fadeSpeed = 1.5f;
    private bool scenceStarting = true;
    public string levelToLoad = "GameMenu";

	// Use this for initialization

	void Start () {
        StartCoroutine("DisplayScene");
	
	}
	
	// Update is called once per frame
    IEnumerator DisplayScene()
    {

        yield return new WaitForSeconds(timer);
        Application.LoadLevel(levelToLoad);
    }
}
