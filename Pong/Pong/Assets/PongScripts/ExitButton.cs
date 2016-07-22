using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {
	// Update is called once per frame
    void OnMouseUp()
    {
        Application.Quit();
    }
}
