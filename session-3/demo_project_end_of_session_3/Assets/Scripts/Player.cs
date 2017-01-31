using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	int score;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Collectable")
		{
			Destroy(other.gameObject);
			score += 1;
			Debug.Log("Score: " + score);
		}

		if(other.tag == "Door" && score > 1)
		{
			Destroy(other.gameObject);
		}
	}
}
