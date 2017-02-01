# Unity and Cake

# Session 4: UI and more code

## What we learned this week

* We learned how to use Unity's UI system to display text and images.

* We learned how to write code that lets components talk to other components.

* We learned how to move between Scenes in Unity.

## This week’s homework

* Read through these notes and keep them handy as you go through the following steps.

* Open the script files we worked on and read the code. Identify the different variables and functions and think about how they work.

* Go through the Resources section at the end of these notes and refresh yourself on what we covered this week.

* Work on your projects! Get your game and title screen looking their best for next week's show and tell.

## The Unity Editor

### UI

We learned how to lay out simple displays using Unity's UI system.

All UI elements need to be children of a GameObject with a Canvas component on it. A Canvas can have multiple child UI elements. Unlike other GameObjects, UI elements don't have a Transform. To change the position of a UI element, we must instead use the UI element's RectTransform. The RectTransform determines how the UI item is positioned within its Canvas.

## Writing code

This week we learned how to write code that lets our components can communicate with other components.

### Access modifiers

When we declare a member variable or a function, we can put the word *private* or *public* in front of it. This is called an **_access modifier_**.

Public variables can be seen and changed by other scripts and the Inspector panel. Public functions can be called by other scripts. Private functions and variables can only be used within the same script.

In C#, if we don’t explicitly declare an access modifier, variables and functions default to *private*.

In the following code, we declare a public variable with a name of *sceneToLoad* and a type of string. Because *sceneToLoad* is a public varaible, we can set its value in the Inspector panel by typing into the **Scene To Load** field.

<pre>
using UnityEngine;

public class LoadSceneOnTriggerEnter : MonoBehaviour 
{
	public string sceneToLoad;

	void OnTriggerEnter (Collider other)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
	}
}
</pre>

### References to other components

Variables can hold much more interesting data that just ints or strings. A variable's value can be another GameObject or Component. In this case, we say that the variable's value is a **_reference_** to that GameObject or component. A variable that holds a reference is called a **_reference typed variable_**.

In the following code, we declare a variable with a name of *progressText* and a type of Text. This means that this variable's value can be set to a specific Text component. Because *progressText* is a public variable, we can set its value in the Inspector panel by dragging a Text component into the **Progress Text** field.

<pre>
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour 
{
	public Text progressText;
}
</pre>

### Accessing variables and functions of other components

If we have a variable that holds a reference to another component, we can access variables and functions of that other Component.

We access variables and functions of components by using the **_dot operator_**. 

To access a public variable of another component, we write the name of the variable that holds the reference to the component, then a dot, then the name of the variable we want to access.

In the following code, the variable named *progressText* has a reference to a Text component. In the *Start* function, we use the dot operator to set the value of the variable *text* on that Text component.

<pre>
using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour 
{
	public Text progressText;
    
    void Start()
    {
        progressText.text = "Hello!";
    }
}
</pre>

In the next example, the function *OnTriggerEnter* receives a parameter with a type of collider and a name of *other*. This means that the variable with the name of *other* holds a reference to a Collider Ccmponent. We use the dot operator to get the value of the public variable *tag* from that Collider component.

<pre>
void OnTriggerEnter (Collider other)
{
	if (other.tag == "Collectable")
	{
        Debug.Log("Collided with a Collectable!");
    }
}
</pre>

## Resources

