# Unity and Cake

# Session 3: Graphics, audio and more code

## What we learned this week

* We learned that Unity takes care of most tasks related to graphics and audio for us, so we only have to add our assets and customise settings.

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

### Graphics

### Audio

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

We set the value of a variable using the = operator, like so:

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

There are various ways of building more complex conditionals that cover all sorts of cases. We'll keep it simple and will only use *if* and *else* statements in this course.

### Operators

We learned a little about operators in C# in order to write our *if* statements.

Most importantly, we learned that a single equals sign sets the value of a variable, and a double equals sign checks if one value is equal to another. We'll usually get an error if we mix these up in our code, but it's good to remember!

We also used the < operator to check if one value was less than another.

## Resources

* To refresh your knowledge of variables and functions in C#, watch [this Unity video on variables and functions](https://unity3d.com/learn/tutorials/topics/scripting/variables-and-functions?playlist=17117).


