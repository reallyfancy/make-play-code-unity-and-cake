# Unity and Cake

# Session 2: Welcome to Unity

## What we learned this week

* We learned what Unity does: it takes care of many common tasks related to building games.

* We learned that most of the assets for a game are created in separate programs and imported into Unity.

* We learned the basics of using the Unity Editor: what the different windows and panels do, the difference between Play Mode and Edit Mode and how to arrange objects in the Scene.

* We learned that the building blocks of Unity are GameObjects and components.

* We learned that we can make our own components by writing code.

## This week’s homework

* Read through these notes and keep them handy as you go through the following steps.

* In Unity, get familiar with using the different windows and panels to explore the project.

* Open the script files we worked on and read the code. Identify the different variables and functions and think about how they work.

* Go through the Resources section at the end of these notes and refresh yourself on what we covered this week. The more familiar you are with the terms and concepts, the easier next week will be!

## The Unity Editor basics

### Understanding GameObjects, components and scripts

The basic building blocks of Unity are **_GameObjects_**. You can think of these as being a bit like sprites in Scratch. GameObjects are blank slates: they don’t do anything, and you can’t see them in the game.

We tell GameObjects to do things by adding **_components_**. A component tells Unity that the GameObject it is attached to should do things such as move, display a shape on the screen, make a sound, and so on. Components are like Lego bricks: you can stack lots of different components on the same GameObject to build something complex.

### Making our own components

Unity contains lots of pre-made components for common tasks such as playing a sound or displaying graphics. We can build simple things with these pre-made components, but to customise our game we must create our own components. We do this by writing **_code_** in a **_script_**.

A script is a blueprint that Unity uses to create a component. The code we write in our script tells Unity how the component will work and what fields to display in the Inspector panel.

## Writing code for Unity

We write code using a language called C# (pronounced *see sharp*). We write our code in a separate program called a **_text editor_** and save our code in a script file. When we return to Unity, we can use the script file in our Unity project.					

### C# basics

Written code is fussy! It can’t understand typos and you have to be careful about small details. Let’s quickly recap the basics that we learned today:

* C# is **_case­ sensitive_**. If the name of something is *score*, C# won’t know what you mean if you try to refer to it as *Score* or *SCORE*. Be careful with the caps lock!

* C# uses a lot of **_brackets_**. Regular brackets like () are used to pass information to our code and and curly brackets like {} are used to separate code into sections. Don’t worry about this too much for now, but do remember: whenever we open a set of brackets, we must close them.

* In C#, we end a line with a **_semicolon_** to indicate that an instruction is finished and that the code on the next line is a separate instruction. A good way to remember whether we need to end a line with a semi­colon is to think of it like the word "STOP" in a telegram.

* We can add **_comments_** to our code by putting two forward slashes at the start of a line. Comments are a way of making notes in our code.

### Variables in C#

When we create a variable, we say that we are **_declaring_** it. When we change its value, we say that we are **_setting_** its value. When we find out its value, we say that we are **_getting_** its value.

#### Declaring variables

In C#, a variable has three things: a name, a value and a **_type_**. The type tells Unity what sort of data is stored in a variable.  When we declare a variable, we need to specify the name and the type, like so:

<pre>
int score;
</pre>

This line tells Unity that we are creating a variable with a type of int and a name of score. 

An int is a round number. Other types we looked at this week include string (a sequence of characters) and bool (true or false).

#### Setting the value

We set the value of a variable using the = operator, like so:

<pre>
score = 100;
</pre>

We can only set the value of a variable to something of the same type of the variable. In the above example, the variable *score* has the type int so its value can only ever be a round number.

#### Declaring a variable and setting the value at the same time

It’s common in C# to declare a variable and set its value at the same time. Let’s take a look at a couple of examples of this:

<pre>
string message = "Hello";
string playerName = "Kerry";
bool isMapScreenShowing = true;
int scoreToWin = 300;
</pre>

#### Getting the value

To get the current value of a variable, we just type its name.

In this example, we use the function *Debug.Log* to print the value of a variable to the console in Unity:

<pre>
string message = "Hello";
Debug.Log(message);
</pre>

#### Special Unity variables

There are a number of special Unity variables that already contain information that we can use in our code.

An example is *name*. All Unity components have a variable called *name*. *name* is a string whose value is the name of the GameObject that the component is attached to. We can use it in our scripts like so:

<pre>
Debug.Log(name);
</pre>

### Functions in C#

A function is a set of instructions, followed in order. When we create a function, we say that we are **_declaring_** the function. When we run the code inside the function, we say that we are **_calling_** the function.

#### Declaring functions

Last week in Scratch, we declared functions by joining blocks together. When we write C#, we declare a function like this:

<pre>
private void PrintToConsole()
{
	Debug.Log("PrintToConsole has been called!");
}
</pre>

The first line tells Unity about the function and how to call it. The most important part of this is the **_name_** of the function. In this example, the name of the function is *PrintToConsole*. Function names must be one word, and are its best to make them descriptive.

The instructions that make up the function go inside the curly brackets. These instructions are called the **_body_** of the function. Each separate line of code is an instruction to Unity to do something, and they are followed in order. In this example, the body of the function sends a message to the console in Unity.

#### Parameters

We can pass variables to functions using **_parameters_**. We’ll look at these in more detail next week, but here’s what a function that accepts parameters looks like:

<pre>
private void PrintPlayerName(string playerName)
{
	Debug.Log("Player name is " + playerName);
}
</pre>

We describe a function’s parameters in the brackets on the first line. We can then use those parameters in the body of the function.

#### Calling functions

To call a function without parameters, we just type its name followed by a set of regular brackets, like so:

<pre>
PrintToConsole();
</pre>

To call a function with parameters, we type its name followed by a set of regular brackets. Inside the brackets, we put the data that we want to pass it as parameters, like so:

<pre>
PrintPlayerName("Kerry");
</pre>

#### Event functions in Unity

In Scratch, we can use Event blocks to run code when the user restarts the game or when the backdrop changes. In Unity, we can do something similar. There are special names for functions, called **_event functions_**. If we create a function with one of these special names, Unity will call it automatically at the appropriate time.

*Start* is an event function. If we put a function named *Start* in our script, Unity will call this function automatically when a GameObject with this script on it first appears in the game.

<pre>
private void Start()
{
	Debug.Log("Start has been called!");
}
</pre>

*OnTriggerEnter* is also an event function. *OnTriggerEnter* is called when another GameObject collides with the GameObject that the script is attached to. There are some conditions about how the collision works - you can read more in the [Unity Scripting Reference page on OnTriggerEnter](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter.html).

## Resources

* To go over what the different windows and panels in the Unity Editor do, watch [this Unity video on the Unity Editor](https://unity3d.com/learn/tutorials/topics/interface-essentials/interface-overview?playlist=17090).

* To refresh your knowledge of variables and functions in C#, watch [this Unity video on variables and functions](https://unity3d.com/learn/tutorials/topics/scripting/variables-and-functions?playlist=17117).

* To make sure you understand the *Start* function in Unity, watch [this Unity video on the Awake and Start functions](https://unity3d.com/learn/tutorials/topics/scripting/awake-and-start?playlist=17117).

* For a good summary on writing scripts to create components, see [this page of the Unity Manual](https://docs.unity3d.com/Manual/CreatingAndUsingScripts.html).

