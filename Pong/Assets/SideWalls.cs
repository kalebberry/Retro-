using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if (hitInfo.name == "Ball")
        {
          
            string wallName = transform.name;
            audio.Play();
            audio.pitch = Random.Range(0.8f, 1.2f);
            GameManager.score(wallName);

            hitInfo.gameObject.SendMessage("ResetBall");
        }

	}
}

