using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Collectable")
		{
			Debug.Log("Collided with a Collectable!");
			Destroy(other.gameObject);
			score += 1;
			Debug.Log("Score: " + score);
		}

		if(other.tag == "Door" && score > 2)
		{
			Destroy(other.gameObject);
		}
	}
}
