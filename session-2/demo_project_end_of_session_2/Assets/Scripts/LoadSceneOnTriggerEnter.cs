using UnityEngine;

public class LoadSceneOnTriggerEnter : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("game");
	}
}