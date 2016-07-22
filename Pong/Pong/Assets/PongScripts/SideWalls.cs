using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f);
            getScore.instance.score(wallName);

            hitInfo.gameObject.SendMessage("ResetBall");
        }

	}
}

