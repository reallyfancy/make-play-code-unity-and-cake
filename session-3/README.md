# Unity and Cake

# Session 3: Graphics, audio and more code

## What we learned this week

* We learned that Unity takes care of most tasks related to graphics and audio for us. We only have to add our assets, wire things together and customise settings.

* We learned the terms for the different components and assets that control graphics and audio in Unity.

* We learned how to import assets into our Unity project.

* We added more code to our components and made a fully functioning game.

## This week’s homework

* Read through these notes and keep them handy as you go through the following steps.

* Open the script files we worked on and read the code. Identify the different variables and functions and think about how they work.

* Go through the Resources section at the end of these notes and refresh yourself on what we covered this week. The more familiar you are with the terms and concepts, the easier next week will be!

* Next week we're going to add some UI to our games. Pick out some fonts you'd like to use on your title screen. If you'd like to add images or audio to your title screen, bring those along too. 

* Work on your projects! Lay out the Scene the way you like, and experiment with assets to get it looking and sounding how you want.

## The Unity Editor

### Prefabs

We looked at **_[Prefabs](https://docs.unity3d.com/Manual/Prefabs.html)_** when we imported assets into our project. A Prefab is an asset that works like a blueprint for a GameObject. When we drag a Prefab from our Project panel into our Scene view or Hierarchy panel, Unity makes a GameObject from that blueprint. This means that GameObject that is placed in our Scene already has all of the same components and settings as the Prefab.

We can recognise a prefab in the Project panel by the blue cube icon. We can recognise a copy of a Prefab in our Hierarchy view as its name appears in blue.

### Graphics

We learned that the term for drawing things to the screen is **_rendering_**. Unity needs several different components and assets in order to render a GameObject. A **_[MeshFilter](https://docs.unity3d.com/Manual/class-MeshFilter.html)_** component has a **_[mesh](https://docs.unity3d.com/Manual/class-Mesh.html)_** asset, and this tells Unity what shape the GameObject is. A **_[Renderer](https://docs.unity3d.com/Manual/class-MeshRenderer.html)_** component has at least one **_[material](https://docs.unity3d.com/Manual/class-Material.html)_** asset, and this tells Unity how to draw the surface of the GameObject.

We created a couple of simple new materials to give our Scene a little colour.

### Audio

We learned that whene we drop an audio file (like an .mp3 or .wav file) into Unity, Unity turns it into an **_[AudioClip]_**(https://docs.unity3d.com/ScriptReference/AudioClip.html) asset. Like all assets in your project, you can select an AudioClip in the Project panel to see information about it in the Inspector panel.

To play and hear an AudioClip, we need two things: an **_[AudioSource](https://docs.unity3d.com/ScriptReference/AudioSource.html)_** and an **_[AudioListener](https://docs.unity3d.com/ScriptReference/AudioListener.html)_**. An AudioSource plays sound, and an AudioListener receives sound.

## Writing code

This week we looked at using variables, conditionals and operators in C# to add logic and interactivity to our games.		

### Variables

When we create a variable, we say that we are **_declaring_** it. When we change its value, we say that we are **_setting_** its value. When we find out its value, we say that we are **_getting_** its value.

#### Declaring variables

In C#, a variable has three things: a name, a value and a **_type_**. The type tells Unity what sort of data is stored in a variable.  When we declare a variable, we need to specify the name and the type, like so:

<pre>
int score;
</pre>

This line tells Unity that we are creating a variable with a type of int and a name of score. 

An int is a round number. Other types we looked at this week include string (a sequence of characters) and bool (true or false).

#### Setting the value of a variable

We can set the value of a variable using the = operator, like so:

<pre>
score = 100;
</pre>

We can only set the value of a variable to something of the same type of the variable. In the above example, the variable *score* has the type int so its value can only ever be a round number.

#### Declaring a variable and setting its value at the same time

It’s common in C# to declare a variable and set its value at the same time. Let’s take a look at a couple of examples of this:

<pre>
string message = "Hello";
string playerName = "Kerry";
bool isMapScreenShowing = true;
int scoreToWin = 300;
</pre>

#### Getting the value of a variable

To get the current value of a variable, we just type its name.

In this example, we use the function *Debug.Log* to print the value of a variable to the console in Unity:

<pre>
string message = "Hello";
Debug.Log(message);
</pre>

### Conditionals

A conditional in C# works the same as it does in Scratch - you have a statement, followed by code that runs if it’s true and, optionally, code that runs if it’s false. We write it like this:

<pre>
if (score == 10)
{
    Debug.Log(“You win”);
}
</pre>

The first line begins with the word *if*, followed by a set of regular brackets containing the statement we want to test. We then have a set of curly brackets, containing the code that runs only if the statement is true.

We can extend a conditional to include code that should run if the statement is false, like this:

<pre>
if (score == 10)
{
    Debug.Log(“You win”);
}
else
{
    Debug.Log("You lose");
}
</pre>

There are various ways of building more complex conditionals that cover all sorts of cases. We'll keep it simple and will only use *if*  statements in this course.

### Operators

We learned a little about operators in C# in order to write our *if* statements.

Most importantly, we learned that a single equals sign sets the value of a variable, and a double equals sign checks if one value is equal to another. We'll usually get an error if we mix these up in our code, but it's good to remember!

We also used the > operator to check if one value was greater than another.

## Resources

* To refresh your knowledge of variables and functions in C#, watch [this Unity video on variables and functions](https://unity3d.com/learn/tutorials/topics/scripting/variables-and-functions?playlist=17117).


