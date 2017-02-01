using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnTriggerEnter : MonoBehaviour 
{
	public string sceneToLoad;

	void OnTriggerEnter (Collider other)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
	}
}
