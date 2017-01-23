using UnityEngine;

public class PrintMessage : MonoBehaviour 
{
	void Start()
	{
		Debug.Log("The function called Start has been called!");
		Debug.Log("These instructions are followed in order!");

		PrintToConsole();
	}

	void PrintToConsole()
	{
		Debug.Log("Now the function called PrintToConsole has been called!");
	}
}
