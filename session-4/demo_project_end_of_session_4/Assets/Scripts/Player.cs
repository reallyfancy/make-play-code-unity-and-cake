using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
	public Text progressText;
	public int collectablesNeeded;
	int score;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Collectable")
		{
			Destroy(other.gameObject);
			score += 1;
			Debug.Log("Score: " + score);
		}

		if(other.tag == "Door" && score >= collectablesNeeded)
		{
			Destroy(other.gameObject);
		}
	}

	void Update()
	{
		progressText.text = score + "/" + collectablesNeeded;
	}
}
